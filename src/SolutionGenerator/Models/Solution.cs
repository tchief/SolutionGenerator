namespace SolutionGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using Catel.Data;

    public class Solution : ModelBase
    {
        public Solution()
        {
            ProjectGuid = Guid.NewGuid().ToString("B");
            SolutionGuid = Guid.NewGuid().ToString("B");
            TestProjectGuid = Guid.NewGuid().ToString("B");

            AvailableLicenses = Directory.EnumerateFiles("./Licenses").Select(Path.GetFileNameWithoutExtension).ToList();
        }

        public bool OpenFolderOnCreate { get; set; }

        [DefaultValue(true)]
        public bool InitializeGit { get; set; }

        [DefaultValue(true)]
        public bool IncludeTestProject { get; set; }

        [DefaultValue(true)]
        public bool IncludeGitIgnore { get; set; }

        [DefaultValue(true)]
        public bool IncludeGitAttribute { get; set; }

        [DefaultValue(true)]
        public bool IncludeReSharper { get; set; }

        [DefaultValue(true)]
        public bool IncludeStylecop { get; set; }

        [DefaultValue(true)]
        public bool IncludeLicense { get; set; }

        [DefaultValue(true)]
        public bool IncludeReadme { get; set; }

        public List<string> AvailableLicenses { get; set; }

        [DefaultValue("MIT")]
        public string LicenseName { get; set; }

        [DefaultValue("{ProjectName}\r\n----------------------------------------------")]
        public string SolutionReadme { get; set; }

        public string TestProjectGuid { get; set; }

        public string SolutionGuid { get; set; }

        public string ProjectGuid { get; set; }

        public string ProjectName { get; set; }

        public string SolutionName { get; set; }

        public string RootPath { get; set; }

        public string ProjectRootNameSpace { get; set; }

        public string ProjectAssemblyName { get; set; }

        [DefaultValue("v4.5")]
        public string TargetFramework { get; set; }

        [DefaultValue(ProjectTypes.Library)]
        public ProjectTypes ProjectType { get; set; }

        public string LicenseText { get; set; }

        public override string ToString()
        {
            return SolutionName ?? string.Empty;
        }
    }
}