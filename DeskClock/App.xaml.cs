using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DeskClock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            String profile = null;
            if ( e.Args.Length == 1 ) profile = e.Args[0];
            MainWindow wnd = new MainWindow(profile);
            wnd.Show();
        }

    }
}
