namespace SolutionGenerator.Frontend.WPF
{
    using System;
    using System.Windows;
    using Catel.IoC;
    using Catel.Windows;
    using SolutionGenerator.Frontend.WPF.Services;
    using SolutionGenerator.Models;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs"/> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            Catel.Logging.LogManager.AddDebugListener();
#endif

            StyleHelper.CreateStyleForwardersForDefaultStyles();

            var serviceLocator = ServiceLocator.Default;

            serviceLocator.RegisterInstance<IConsoleService>(new ConsoleService());

            // Force load assembly
            Console.WriteLine(typeof (Solution));

            base.OnStartup(e);
        }
    }
}