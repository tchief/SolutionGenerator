namespace SolutionGenerator.Services
{
    using Catel;

    public class GitService : IGitService
    {
        public void InitGitRepository(string directoryName)
        {
            Argument.IsNotNullOrWhitespace(() => directoryName);

            LibGit2Sharp.Repository.Init(directoryName);
        }
    }
}
