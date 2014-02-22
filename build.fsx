#r @"tools\FAKE\tools\FakeLib.dll"

open System
open System.IO
open System.Linq
open System.Text
open System.Text.RegularExpressions
open Fake
open Fake.MSTest

// --------------------------------------------------------------------------------------
// Definitions

let binProjectName = "SolutionGenerator"
let chocoBinProjectName = "SolutionGenerator.Frontend.Wpf"
let netVersions = ["NET45"]

let srcDir  = @".\src\"
let deploymentDir  = @".\deployment\"
let packagesDir = deploymentDir @@ "packages"

let dllDeploymentDirs = netVersions |> List.map(fun v -> v, packagesDir @@ "work" @@ "lib" @@ v) |> dict
let nuspecTemplatesDir = deploymentDir @@ "templates"

let nugetExePath = @".\src\.nuget\nuget.exe"
let nugetRepositoryDir = srcDir @@ @"packages"
let getBuildParamOrFromFileOrEmpty param file = getBuildParamOrDefault param (if File.Exists(file) then File.ReadAllText(file) else "")
let nugetAccessPublishKey = getBuildParamOrFromFileOrEmpty "nugetkey" @".\Nuget.key"
let chocoAccessPublishKey = getBuildParamOrFromFileOrEmpty "chocokey" @".\Choco.key"

let version = File.ReadAllText(@".\version.txt")
let solutionAssemblyInfoPath = srcDir @@ "SolutionAssemblyInfo.cs"

let projectsToPackageAssemblyNames = ["SolutionGenerator"]
let projectsToPackageDependencies:^string list = ["Catel.Core"; "Catel.Fody"; "Fody"; "LibGit2Sharp"; "ModuleInit.Fody"]
let chocoExtensionsToPackage = [".dll"; ".exe"; ".txt"; ".xml"; ".config"; ".gui"; ".csx"]
let chocoProjectsToPackageAssemblyNames = ["SolutionGenerator.Frontend.Wpf";]
let chocoProjectsToPackageDependencies =  []

let outputDir = @".\output\"
let outputReleaseDir = outputDir @@ "release" ////@@ netVersion
let outputBinDir = outputReleaseDir ////@@ binProjectName
let getProjectOutputBinDirs netVersion projectName = outputBinDir @@ netVersion @@ projectName
let testResultsDir = srcDir @@ "TestResults"

let ignoreBinFiles = "*.vshost.exe"
let ignoreBinFilesPattern = @"\**\" @@ ignoreBinFiles
let outputBinFiles = !! (outputBinDir @@ @"\**\*.*")
                            -- ignoreBinFilesPattern

let tests = srcDir @@ @"\**\*.Tests.csproj" 
let allProjects = srcDir @@ @"\**\*.csproj" 

let testProjects  = !! tests
let otherProjects = !! allProjects
                        -- tests

// --------------------------------------------------------------------------------------
// Clean build results

Target "CleanPackagesDirectory" (fun _ ->
    CleanDirs [packagesDir; testResultsDir]
)

Target "DeleteOutputFiles" (fun _ ->
    !! (outputDir + @"\**\*.*")
       ++ (testResultsDir + @"\**\*.*")
        -- ignoreBinFilesPattern
    |> DeleteFiles
)

Target "DeleteOutputDirectories" (fun _ ->
    CreateDir outputDir
    DirectoryInfo(outputDir).GetDirectories("*", SearchOption.AllDirectories)
    |> Array.filter (fun d -> not (d.GetFiles(ignoreBinFiles, SearchOption.AllDirectories).Any()))
    |> Array.map (fun d -> d.FullName)
    |> DeleteDirs
)

// --------------------------------------------------------------------------------------
// Build projects

Target "RestorePackagesManually" (fun _ ->
      !! "./**/packages.config"
      |> Seq.iter (RestorePackage (fun p -> { p with
                                                 ToolPath = nugetExePath
                                                 OutputPath = nugetRepositoryDir}))
)

Target "UpdateAssemblyVersion" (fun _ ->
      let pattern = Regex("Assembly(|File)Version(\w*)\(.*\)")
      let result = "Assembly$1Version$2(\"" + version + "\")"
      let content = File.ReadAllLines(solutionAssemblyInfoPath, Encoding.Unicode)
                    |> Array.map(fun line -> pattern.Replace(line, result, 1))
      File.WriteAllLines(solutionAssemblyInfoPath, content, Encoding.Unicode)
)

Target "BuildOtherProjects" (fun _ ->    
    otherProjects
      |> MSBuildRelease "" "Rebuild" 
      |> Log "Build Other Projects"
)

Target "BuildTests" (fun _ ->    
    testProjects
      |> MSBuildRelease "" "Build"
      |> Log "Build Tests"
)

// --------------------------------------------------------------------------------------
// Run tests

Target "RunTests" (fun _ ->
    ActivateFinalTarget "CloseMSTestRunner"
    CleanDir testResultsDir
    CreateDir testResultsDir

    !! (outputDir + @"\**\*.Tests.dll") 
    ++ (outputDir + @"\**\*.Test.dll") 
      |> MSTest (fun p ->
                  { p with
                     TimeOut = TimeSpan.FromMinutes 20.
                     ResultsDir = testResultsDir})
)

FinalTarget "CloseMSTestRunner" (fun _ ->  
    ProcessHelper.killProcess "mstest.exe"
)

// --------------------------------------------------------------------------------------
// Build a NuGet package

Target "NuGet" (fun _ ->
    let getOutputFile netVersion projectName ext = sprintf @"%s\%s.%s" (getProjectOutputBinDirs netVersion projectName) projectName ext
    let getBinProjectFiles netVersion projectName =  [(getOutputFile netVersion projectName "dll")
                                                      (getOutputFile netVersion projectName "xml")]
    let binProjectFiles netVersion = projectsToPackageAssemblyNames
                                       |> List.collect(fun d -> getBinProjectFiles netVersion d)
                                       |> List.filter(fun d -> File.Exists(d))

    let nugetDependencies = projectsToPackageDependencies
                              |> List.map (fun d -> d, GetPackageVersion nugetRepositoryDir d)
    
    let getNuspecFile = sprintf "%s\%s.nuspec" nuspecTemplatesDir binProjectName

    let preparePackage filesToPackage = 
        CreateDir (packagesDir @@ "work")
        dllDeploymentDirs.Values |> Seq.iter (fun d -> CreateDir d)
        dllDeploymentDirs |> Seq.iter (fun d -> CopyFiles d.Value (filesToPackage d.Key))

    let cleanPackage name = 
        DeleteDir (packagesDir @@ "work")

    let doPackage dependencies =   
        NuGet (fun p -> 
            {p with
                Project = binProjectName
                Version = version
                ToolPath = nugetExePath
                OutputPath = packagesDir
                WorkingDir = packagesDir @@ "work"
                Dependencies = dependencies
                Publish = not (String.IsNullOrEmpty nugetAccessPublishKey)
                AccessKey = nugetAccessPublishKey })
                getNuspecFile
    
    let doAll files depenencies =
        preparePackage files
        doPackage depenencies
        cleanPackage ""

    doAll binProjectFiles nugetDependencies
)

// --------------------------------------------------------------------------------------
// Build a Chocolatey package

Target "Chocolatey" (fun _ ->
    let outputChocoBinDir = getProjectOutputBinDirs (netVersions.First()) chocoBinProjectName

    let outputChocoBinExe = sprintf @"%s\%s.exe" outputChocoBinDir chocoBinProjectName
    File.Copy(outputChocoBinExe, (outputChocoBinExe + ".gui"))

    let nugetDependencies = chocoProjectsToPackageDependencies
                              |> List.map (fun d -> d, GetPackageVersion nugetRepositoryDir d)
    
    let getNuspecFile = sprintf "%s\%s.nuspec" nuspecTemplatesDir chocoBinProjectName

    let preparePackage dirToPackage = 
        let chocoDeploymentToolsDir = packagesDir @@ "work" @@ "tools"
        let filesFilter path = chocoExtensionsToPackage.Contains(Path.GetExtension(path))
        CopyDir chocoDeploymentToolsDir dirToPackage filesFilter

    let cleanPackage name = 
        DeleteDir (packagesDir @@ "work")

    let doPackage dependencies =   
        NuGet (fun p -> 
            {p with
                Project = binProjectName
                Version = version
                ToolPath = nugetExePath
                OutputPath = packagesDir
                WorkingDir = packagesDir @@ "work"
                Dependencies = dependencies
                Publish = not (String.IsNullOrEmpty chocoAccessPublishKey)
                PublishUrl = "http://chocolatey.org/"
                AccessKey = chocoAccessPublishKey })
                getNuspecFile
    
    let doAll files depenencies =
        preparePackage files
        doPackage depenencies
        cleanPackage ""

    doAll outputChocoBinDir nugetDependencies
)

// --------------------------------------------------------------------------------------
// Combined targets

Target "Clean" DoNothing
"CleanPackagesDirectory" ==> "DeleteOutputFiles" ==> "DeleteOutputDirectories" ==> "Clean"

Target "Build" DoNothing
"UpdateAssemblyVersion" ==> "RestorePackagesManually" ==> "BuildOtherProjects" ==> "Build"

Target "Tests" DoNothing
//"BuildTests" ==> "RunTests" ==> "Tests"

Target "All" DoNothing
"Clean" ==> "All"
"Build" ==> "All"
"Tests" ==> "All"

Target "Release" DoNothing
"All" ==> "Release"
"NuGet" ==> "Release"
"Chocolatey" ==> "Release"
 
RunTargetOrDefault "All"
