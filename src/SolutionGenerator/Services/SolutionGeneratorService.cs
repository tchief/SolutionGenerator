namespace SolutionGenerator.Services
{
    using System.Collections.Generic;
    using System.IO;
    using Catel;
    using Models;

    public class SolutionGeneratorService : ISolutionGeneratorService
    {
        private readonly IGitService _gitService;
        private readonly ITemplateRenderer _templateRenderer;
        private const string SolutionTemplate = "./Templates/SolutionTemplate.txt";
        private const string SolutionWithTestTemplate = "./Templates/SolutionWithTestTemplate.txt";
        private const string ProjectTemplate = "./Templates/ProjectTemplate.txt";
        private const string GitAttributeTemplate = "./Templates/gitAttributeTemplate.txt";
        private const string GitIgnoreTemplate = "./Templates/gitIgnoreTemplate.txt";
        private const string ReadmeTemplate = "./Templates/ReadmeTemplate.txt";
        private const string ResharperSettingsTemplate = "./Templates/resharperSettingsTemplate.txt";
        private const string StyleCopTemplate = "./Templates/styleCopTemplate.txt";
        private const string LicenseTemplate = "./Templates/licenseTemplate.txt";
        private const string PackagesTemplate = "./Templates/packagesConfigTemplate.txt";
        private const string ConsoleProgramClass = "./Templates/consoleProgramClass.txt";

        private const string AppXaml = "./Templates/WPF/appXaml.txt";
        private const string AppXamlCs = "./Templates/WPF/appXamlCs.txt";
        private const string MainWindowXaml = "./Templates/WPF/mainWindowXaml.txt";
        private const string MainWindowXamlCs = "./Templates/WPF/mainWindowXamlCs.txt";

        private const string ProgramCs = "./Templates/Winform/programCs.txt";
        private const string Form1DesignerCs = "./Templates/Winform/form1DesignerCs.txt";
        private const string Form1Cs = "./Templates/Winform/form1Cs.txt";

        private const string FolderStructureFile = "./folders.txt";

        public SolutionGeneratorService(IGitService gitService, ITemplateRenderer templateRenderer)
        {
            Argument.IsNotNull(() => gitService);
            Argument.IsNotNull(() => templateRenderer);

            _gitService = gitService;
            _templateRenderer = templateRenderer;
        }

        public void DoWork(SolutionModel model)
        {
            Argument.IsNotNull(() => model);

            // create folders under root path
            var rootDirectoryInfo = new DirectoryInfo(model.RootPath);
            CreateFolderStructure(rootDirectoryInfo);
            CreateSolutionAssets(rootDirectoryInfo, model);

            // create files under root/src path
            rootDirectoryInfo = new DirectoryInfo(string.Format("{0}/src/", model.RootPath));
            CreateSolutionFile(rootDirectoryInfo, model);
            CreateProjectFile(rootDirectoryInfo, model);
            if (model.IncludeTestProject)
            {
                CreateTestProjectFile(rootDirectoryInfo, model);
            }
            CreateProjectAssets(rootDirectoryInfo, model);

            if (model.InitializeGit)
            {
                _gitService.InitGitRepository(rootDirectoryInfo.FullName);
            }
        }

        private void CreateFolderStructure(DirectoryInfo root)
        {
            if (!root.Exists)
            {
                root.Create();
            }

            var directoryCreator = new DirectoryCreator(new FileInfo(FolderStructureFile), root);
            directoryCreator.CreateDirectoryStructure();
        }

        private FileInfo CreateSolutionFile(DirectoryInfo root, SolutionModel model)
        {
            var templateToRender = model.IncludeTestProject ? SolutionWithTestTemplate : SolutionTemplate;
            var solutionFile = new FileInfo(string.Format("{0}{1}.sln", root.FullName, model.SolutionName));
            
            File.WriteAllText(solutionFile.FullName, _templateRenderer.Render(templateToRender, model));

            return solutionFile;
        }

        private FileInfo CreateProjectFile(DirectoryInfo root, SolutionModel model)
        {
            string projectRoot = string.Format("{0}/{1}/", root.FullName, model.ProjectName);
            var directoryInfo = new DirectoryInfo(projectRoot);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            var projectModel = new ProjectModel(model.TestProjectGuid)
            {
                ProjectAssemblyName = model.ProjectAssemblyName,
                ProjectName = model.ProjectName,
                ProjectRootNameSpace = model.ProjectRootNameSpace,
                TargetFramework = model.TargetFramework,
                ReleaseOutputPath = string.Format("../../output/Release/{0}", model.ProjectName),
                DebugOutputPath = string.Format("../../output/Debug/{0}", model.ProjectName),
                ProjectType = model.ProjectType
            };

            projectModel.ProjectOutputType = projectModel.ProjectTypeToProjectOutputType(model.ProjectType);
            projectModel.AddCoreReferences();
            
            if (projectModel.ProjectOutputType == "Exe")
            {
                File.WriteAllText(projectRoot + "Program.cs", _templateRenderer.Render(ConsoleProgramClass, projectModel));
            }
            else if (model.ProjectType == "WPF")
            {
                File.WriteAllText(projectRoot + "App.xaml", _templateRenderer.Render(AppXaml, projectModel));
                File.WriteAllText(projectRoot + "App.xaml.cs", _templateRenderer.Render(AppXamlCs, projectModel));
                File.WriteAllText(projectRoot + "MainWindow.xaml", _templateRenderer.Render(MainWindowXaml, projectModel));
                File.WriteAllText(projectRoot + "MainWindow.xaml.cs", _templateRenderer.Render(MainWindowXamlCs, projectModel));
            }
            else if (model.ProjectType == "WinForms")
            {
                File.WriteAllText(projectRoot + "Form1.cs", _templateRenderer.Render(Form1Cs, projectModel));
                File.WriteAllText(projectRoot + "Form1.Designer.cs", _templateRenderer.Render(Form1DesignerCs, projectModel));
                File.WriteAllText(projectRoot + "Program.cs", _templateRenderer.Render(ProgramCs, projectModel));
            }

            var projectFile = new FileInfo(projectRoot + projectModel.ProjectName + ".csproj");
            File.WriteAllText(projectFile.FullName, _templateRenderer.Render(ProjectTemplate, projectModel));
            
            return projectFile;
        }

        private FileInfo CreateTestProjectFile(DirectoryInfo root, SolutionModel model)
        {
            string projectRoot = string.Format("{0}/{1}.Tests/", root.FullName, model.ProjectName);
            var directoryInfo = new DirectoryInfo(projectRoot);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            var projectName = string.Format("{0}.Tests", model.ProjectName);
            var projectModel = new ProjectModel(model.TestProjectGuid)
            {
                ProjectAssemblyName = string.Format("{0}.Tests", model.ProjectAssemblyName),
                ProjectName = projectName,
                ProjectRootNameSpace = string.Format("{0}.Tests", model.ProjectRootNameSpace),
                TargetFramework = model.TargetFramework,
                ReleaseOutputPath = string.Format("../../output/Release/{0}", projectName),
                DebugOutputPath = string.Format("../../output/Debug/{0}", projectName),
                ProjectOutputType = "Library",
            };

            if (model.TargetFramework == "v4.5")
            {
                projectModel.ProjectType = "Test";
                var packagesFile = new FileInfo(projectRoot + "packages.config");
                File.WriteAllText(packagesFile.FullName, _templateRenderer.Render(PackagesTemplate, projectModel));
            }

            projectModel.AddCoreReferences();

            var projectFile = new FileInfo(projectRoot + projectModel.ProjectName + ".csproj");
            File.WriteAllText(projectFile.FullName, _templateRenderer.Render(ProjectTemplate, projectModel));

            return projectFile;
        }

        private FileInfo[] CreateSolutionAssets(DirectoryInfo root, SolutionModel model)
        {
            var files = new List<FileInfo>();

            FileInfo solutionFile;

            if (model.IncludeGitAttribute)
            {
                solutionFile = new FileInfo(string.Format("{0}/.gitattributes", root.FullName));
                File.WriteAllText(solutionFile.FullName, _templateRenderer.Render(GitAttributeTemplate, model));
                files.Add(solutionFile);
            }
            if (model.IncludeGitIgnore)
            {
                solutionFile = new FileInfo(string.Format("{0}/.gitignore", root.FullName));
                File.WriteAllText(solutionFile.FullName, _templateRenderer.Render(GitIgnoreTemplate, model));
                files.Add(solutionFile);
            }
            if (model.IncludeReadme)
            {
                solutionFile = new FileInfo(string.Format("{0}/README.md", root.FullName));
                File.WriteAllText(solutionFile.FullName, _templateRenderer.RenderAndRenderContent(ReadmeTemplate, model));
                files.Add(solutionFile);
            }
            if (model.IncludeLicense)
            {
                solutionFile = new FileInfo(string.Format("{0}/License.txt", root.FullName));
                File.WriteAllText(solutionFile.FullName, model.LicenseText);
                files.Add(solutionFile);
            }
            return files.ToArray();
        }

        private FileInfo[] CreateProjectAssets(DirectoryInfo root, SolutionModel model)
        {
            var files = new List<FileInfo>();

            FileInfo solutionFile;
            if (model.IncludeReSharper)
            {
                solutionFile = new FileInfo(string.Format("{0}/resharper.settings", root.FullName));
                File.WriteAllText(solutionFile.FullName, _templateRenderer.Render(ResharperSettingsTemplate, model));
                files.Add(solutionFile);
            }
            if (model.IncludeStylecop)
            {
                solutionFile = new FileInfo(string.Format("{0}/Settings.StyleCop", root.FullName));
                File.WriteAllText(solutionFile.FullName, _templateRenderer.Render(StyleCopTemplate, model));
                files.Add(solutionFile);
            }
            return files.ToArray();
        }
    }
}
