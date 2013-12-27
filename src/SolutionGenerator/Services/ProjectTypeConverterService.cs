// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectTypeConverterService.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    using System;
    using System.ComponentModel;
    using Catel;

    public class ProjectTypeConverterService : IProjectTypeConverterService
    {
        public ProjectOutputTypes Convert(ProjectTypes projectType)
        {
            Argument.IsNotNull(() => projectType);

            switch (projectType)
            {
                case ProjectTypes.Console:
                    return ProjectOutputTypes.Console;
                    
                case ProjectTypes.WPF:
                    return ProjectOutputTypes.WPF;
                    
                case ProjectTypes.WinForms:
                    return ProjectOutputTypes.WinForms;

                case ProjectTypes.Test:
                    return ProjectOutputTypes.Test;

                case ProjectTypes.Library:
                    return ProjectOutputTypes.Library;

                default:
                    throw new ArgumentOutOfRangeException("projectType");
            }
        }
    }
}