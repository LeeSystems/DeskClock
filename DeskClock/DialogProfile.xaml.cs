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
    /// Interaction logic for DialogProfile.xaml
    /// </summary>
    public partial class DialogProfile : Window
    {
        public DialogProfile()
        {
            InitializeComponent();
            this.DataContext = MainWindow.Config;
            MainWindow.Config.LoadProfileList();
            MainWindow.Config.ProfileNameSelected = MainWindow.Config.ProfileNameLoaded;
        }

        private void Button_New_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.Config.IsProfileNameValid(MainWindow.Config.ProfileNameSelected))
            {
                if(MainWindow.Config.IsProfileNameExisting(MainWindow.Config.ProfileNameSelected))
                {
                    System.Windows.MessageBoxResult mr = System.Windows.MessageBox.Show(String.Format("Warning - \"{0}\" already exists , Do you want to overwrite!",
                        MainWindow.Config.ProfileNameSelected),
                        "Overwrite", System.Windows.MessageBoxButton.OKCancel, 
                        System.Windows.MessageBoxImage.Question);
                    if (mr == MessageBoxResult.OK)
                    {
                        MainWindow.Config.UserProfileSave(MainWindow.Config.ProfileNameSelected);
                        MainWindow.Config.ProfileNameSelected = MainWindow.Config.ProfileNameLoaded;
                    }
                }
                else
                {
                    MainWindow.Config.UserProfileSave(MainWindow.Config.ProfileNameSelected);
                }
            }
            else
            {
                System.Windows.MessageBoxResult mr = System.Windows.MessageBox.Show(String.Format("Error - the profile nema \"{0}\" is indalid" ,
                       MainWindow.Config.ProfileNameSelected),
                       "Error", System.Windows.MessageBoxButton.OK, 
                       System.Windows.MessageBoxImage.Exclamation);
            }
        }

        private void Button_Load_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Config.UserProfileLoad(MainWindow.Config.ProfileNameSelected);
            this.Close();
        }

        private void Button_Detete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Config.DeleteProfile(MainWindow.Config.ProfileNameSelected);
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
