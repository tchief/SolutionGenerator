namespace SolutionGenerator.Models
{
    using Base;

    public class ProjectModel : ModelBase
    {
        public string ProjectName { get; set; }
        public string ProjectAssemblyName { get; set; }
        public string ProjectRootNameSpace { get; set; }
        public string ProjectGuid { get; set; }
        public string TargetFramework { get; set; }

        public ProjectModel(string projectGuid)
        {
            ProjectGuid = projectGuid;
        }
    }
}