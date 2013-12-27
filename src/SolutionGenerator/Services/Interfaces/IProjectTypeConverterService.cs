// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProjectTypeConverterService.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    public interface IProjectTypeConverterService
    {
        ProjectOutputTypes Convert(ProjectTypes projectType);
    }
}