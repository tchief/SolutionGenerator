// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolutionOptionsViewModel.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Frontend.WPF.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Catel;
    using Catel.Logging;
    using Catel.MVVM;
    using SolutionGenerator.Models;

    public class SolutionOptionsViewModel : ViewModelBase
    {
        #region Constructors
        public SolutionOptionsViewModel(Solution solution)
        {
            Argument.IsNotNull(() => solution);

            Solution = solution;

            AvailableLicenseNames = Solution.AvailableLicenses;
            AvailableProjectTypes = new ObservableCollection<ProjectTypes>(Enum<ProjectTypes>.GetValues());

            // TODO: Read from registry instead in service
            AvailableTargetFrameworks = new ObservableCollection<string>(new[] { "v2.0", "v3.0", "v3.5", "v4.0", "v4.5" });
        }
        #endregion

        #region Properties
        [Model]
        [Catel.Fody.Expose("RootPath")]
        [Catel.Fody.Expose("SolutionName")]
        [Catel.Fody.Expose("ProjectName")]
        [Catel.Fody.Expose("ProjectType")]
        [Catel.Fody.Expose("ProjectRootNameSpace")]
        [Catel.Fody.Expose("ProjectAssemblyName")]
        [Catel.Fody.Expose("TargetFramework")]
        [Catel.Fody.Expose("LicenseName")]
        [Catel.Fody.Expose("Readme", "SolutionReadme")]
        public Solution Solution { get; private set; }

        public ObservableCollection<ProjectTypes> AvailableProjectTypes { get; private set; }

        public ObservableCollection<string> AvailableTargetFrameworks { get; private set; }

        public List<string> AvailableLicenseNames { get; private set; }
        #endregion
    }
}