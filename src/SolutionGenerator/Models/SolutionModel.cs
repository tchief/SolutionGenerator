namespace SolutionGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Catel.Data;

    public class SolutionModel : ModelBase
    {
        public SolutionModel()
        {
            ProjectGuid = Guid.NewGuid().ToString("B");
            SolutionGuid = Guid.NewGuid().ToString("B");
            TestProjectGuid = Guid.NewGuid().ToString("B");
            TargetFramework = "v4.5";
            SolutionReadme = "{ProjectName}\r\n----------------------------------------------";

            IncludeTestProject    = true;
            IncludeGitIgnore      = true;
            IncludeGitAttribute   = true;
            IncludeReSharper      = true;
            IncludeStylecop       = true;
            IncludeLicense        = true;
            IncludeReadme         = true;
            LicenseName           = "MIT";
            InitializeGit         = true;

            ProjectType = "Library";
            AvailableLicenses = Directory.EnumerateFiles("./Licenses").Select(Path.GetFileNameWithoutExtension).ToList();
        }

        public bool OpenFolderOnCreate { get; set; }
        public bool InitializeGit { get; set; }
        public bool IncludeTestProject { get; set; }
        public bool IncludeGitIgnore { get; set; }
        public bool IncludeGitAttribute { get; set; }
        public bool IncludeReSharper { get; set; }
        public bool IncludeStylecop { get; set; }
        public bool IncludeLicense { get; set; }
        public bool IncludeReadme { get; set; }

        public List<string> AvailableLicenses { get; set; }
        public string LicenseName { get; set; }

        public string SolutionReadme { get; set; }

        public string TestProjectGuid { get; set; }

        public string SolutionGuid { get; set; }

        public string ProjectGuid { get; set; }

        public string ProjectName { get; set; }

        public string SolutionName { get; set; }

        public string RootPath { get; set; }

        public string ProjectRootNameSpace { get; set; }

        public string ProjectAssemblyName { get; set; }

        public string TargetFramework { get; set; }

        public string ProjectType { get; set; }

        public string LicenseText { get; set; }
    }
}