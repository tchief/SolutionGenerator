namespace SolutionGenerator
{
    using System.Collections.Generic;
    using System.IO;

    public class SolutionGeneratorService
    {
        private const string SolutionTemplate = "./Templates/SolutionTemplate.txt";
        private const string ProjectTemplate = "./Templates/ProjectTemplate.txt";
        private const string GitAttributeTemplate = "./Templates/gitAttributeTemplate.txt";
        private const string GitIgnoreTemplate = "./Templates/gitIgnoreTemplate.txt";
        private const string ReadmeTemplate = "./Templates/ReadmeTemplate.txt";
        private const string ResharperSettingsTemplate = "./Templates/resharperSettingsTemplate.txt";
        private const string StyleCopTemplate = "./Templates/styleCopTemplate.txt";

        public void DoWork(SolutionModel model)
        {
            // create folders under root path
            var rootDirectoryInfo = new DirectoryInfo(model.RootPath);
            CreateFolderStructure(rootDirectoryInfo);
            CreateSolutionAssets(rootDirectoryInfo, model);

            // create files under root/src path
            rootDirectoryInfo = new DirectoryInfo(string.Format("{0}/src/", model.RootPath));
            CreateSolutionFile(rootDirectoryInfo, model);
            CreateProjectFile(rootDirectoryInfo, model);
            CreateProjectAssets(rootDirectoryInfo, model);
        }

        private void CreateFolderStructure(DirectoryInfo root)
        {
            if (!root.Exists)
            {
                root.Create();
            }

            root.CreateSubdirectory("src");
            root.CreateSubdirectory("lib");
            root.CreateSubdirectory("docs");
            root.CreateSubdirectory("output");
            root.CreateSubdirectory("tools");
        }

        private FileInfo CreateSolutionFile(DirectoryInfo root, SolutionModel model)
        {
            var solutionFile = new FileInfo(string.Format("{0}{1}.sln", root.FullName, model.SolutionName));
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(SolutionTemplate, model));

            return solutionFile;
        }

        private FileInfo CreateProjectFile(DirectoryInfo root, SolutionModel model)
        {
            string projectRoot = root.FullName + "/" + model.ProjectName + "/";
            var directoryInfo = new DirectoryInfo(projectRoot);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            var solutionFile = new FileInfo(projectRoot + model.ProjectName + ".csproj");
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(ProjectTemplate, model));

            return solutionFile;
        }

        private FileInfo[] CreateSolutionAssets(DirectoryInfo root, SolutionModel model)
        {
            var files = new List<FileInfo>();

            var solutionFile = new FileInfo(root.FullName + "/.gitattributes");
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(GitAttributeTemplate, model));
            files.Add(solutionFile);

            solutionFile = new FileInfo(root.FullName + "/.gitignore");
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(GitIgnoreTemplate, model));
            files.Add(solutionFile);

            solutionFile = new FileInfo(root.FullName + "/README.md");
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(ReadmeTemplate, model));
            files.Add(solutionFile);

            return files.ToArray();
        }

        private FileInfo[] CreateProjectAssets(DirectoryInfo root, SolutionModel model)
        {
            var files = new List<FileInfo>();

            var solutionFile = new FileInfo(root.FullName + "/resharper.settings");
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(ResharperSettingsTemplate, model));
            files.Add(solutionFile);

            solutionFile = new FileInfo(root.FullName + "/Settings.StyleCop");
            File.WriteAllText(solutionFile.FullName, TemplateRenderer.Render(StyleCopTemplate, model));
            files.Add(solutionFile);

            return files.ToArray();
        }
    }
}
