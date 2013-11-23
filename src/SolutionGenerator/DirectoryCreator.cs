using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGenerator
{
    public class DirectoryCreator
    {
        public FileInfo FolderConfigFile { get; set; }
        public DirectoryInfo RootFolder { get; set; }

        public DirectoryCreator(FileInfo folderConfigFile, DirectoryInfo rootFolder)
        {
            FolderConfigFile = folderConfigFile;
            RootFolder = rootFolder;
        }

        public void CreateDirectoryStructure()
        {
            string[] directoriesToCreate = File.ReadAllLines(FolderConfigFile.FullName);

            foreach (string dir in directoriesToCreate)
            {
                RootFolder.CreateSubdirectory(dir);
            }
        }
    }
}
