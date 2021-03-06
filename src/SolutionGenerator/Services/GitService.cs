﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitService.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    using Catel;

    public class GitService : IGitService
    {
        #region IGitService Members
        public void InitGitRepository(string directoryName)
        {
            Argument.IsNotNullOrWhitespace(() => directoryName);

            LibGit2Sharp.Repository.Init(directoryName);
        }
        #endregion
    }
}