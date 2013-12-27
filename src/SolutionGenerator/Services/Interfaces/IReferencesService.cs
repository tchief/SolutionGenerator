// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReferencesService.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    using SolutionGenerator.Models;

    public interface IReferencesService
    {
        void AddRequiredReferences(Project project);
        void AddRequiredReferences(Project project, ProjectReference projectReference);
        ProjectReference GetNUnitReferences();
        ProjectReference GetWinFormsReferences();
        ProjectReference GetCoreReferences();
        ProjectReference GetWpfReference();
        ProjectReference GetConsoleReferences();
    }
}