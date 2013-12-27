// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISolutionGeneratorService.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    using SolutionGenerator.Models;

    public interface ISolutionGeneratorService
    {
        #region Methods
        void DoWork(Solution model);
        #endregion
    }
}