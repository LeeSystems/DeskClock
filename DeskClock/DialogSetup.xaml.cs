using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeskClock
{
    /// <summary>
    /// Interaction logic for DilogSetup.xaml
    /// </summary>
    public partial class DilogSetup : Window
    {
        public enum DialogCloseType { None, Exit, Save }
        public DialogCloseType DialogCloseAction { get; private set; }
        public BrushColorItems BrushListFull { get; set; }

        public DilogSetup()
        {
            BrushListFull = new BrushColorItems();
            InitializeComponent();
            this.DataContext = MainWindow.Config;
            DialogCloseAction = DialogCloseType.None;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            DialogCloseAction = DialogCloseType.None;
            this.Close();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            DialogCloseAction = DialogCloseType.Exit;
            this.Close();
        }


        private void Button_Load_Click(object sender, RoutedEventArgs e)
        {
            DialogProfile dialogProfile = new DialogProfile();
            dialogProfile.ShowDialog();

        }

        private void Button_LoadDefaults_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Config.SetDefaults();
        }
    }
}
