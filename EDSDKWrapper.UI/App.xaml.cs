using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace EDSDKWrapper.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            this.DispatcherUnhandledException+=new System.Windows.Threading.DispatcherUnhandledExceptionEventHandler(
                (s,e)=>
                {
                    string message = e.Exception.ToString();

                    MessageBox.Show(message);

                    e.Handled = true;
                });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var view = new MainView();
            var viewModel = new MainViewModel();

            view.DataContext = viewModel;
            view.Show();
        }
    }
}
