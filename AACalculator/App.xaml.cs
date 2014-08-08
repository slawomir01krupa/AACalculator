using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;
using AACalculator.Bootstrapper;
using AACalculator.Core;
using AACalculator.ExceptionNotifier.ViewModel;

namespace AACalculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ShutdownMode = ShutdownMode.OnLastWindowClose;
        }


        private void BootStrapper(object sender, StartupEventArgs e)
        {
            FrameworkElement.LanguageProperty.OverrideMetadata(
                typeof(FrameworkElement),
                new FrameworkPropertyMetadata(
                    XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            var boot = new AACalculatorBootstrapper();
            boot.Run();
            //Shutdown();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Current.DispatcherUnhandledException += AppDispatcherUnhandledException;

            base.OnStartup(e);
        }

        private void AppDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            if (e.Exception is SuspendedProcessException) { return; }
            new ExceptionNotifierViewModel(e.Exception);
        }
    }
}
