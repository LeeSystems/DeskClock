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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeskClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Configuration Config { set; get; }
        private String Profile { set; get; }

        public DateTime DateTimeNow
        {
            get { return (DateTime)GetValue(DateTimeNowProperty); }
            set { SetValue(DateTimeNowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DateTimeNow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateTimeNowProperty =
            DependencyProperty.Register("DateTimeNow", typeof(DateTime), typeof(MainWindow), new PropertyMetadata(DateTime.Now));



        private int p_SecondsNow;
        public int SecondsNow
        {
            get { return (int)GetValue(SecondsNowProperty); }
            set { SetValue(SecondsNowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SecondsNow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondsNowProperty =
            DependencyProperty.Register("SecondsNow", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



        public Brush CurrentSecondsBarColor
        {
            get { return (Brush)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("CurrentSecondsBarColor", typeof(Brush), typeof(MainWindow), new PropertyMetadata(Brushes.Green));


        private System.Windows.Threading.DispatcherTimer dispatcherTimer;

        public MainWindow(String profile)
        {
            Config = new Configuration();
            InitializeComponent();
#if DEBUG
            ResizeMode = ResizeMode.CanResizeWithGrip;
#endif
            DataContext = this;
            Config.DeskClockWindow = this;
            Profile = profile;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // get time
            DateTime dateTime = DateTime.UtcNow;
            dateTime = dateTime.Add(Config.TimeZoneSelected.GetUtcOffset(dateTime));
            DateTimeNow = dateTime;
            // get seconds for seconds bar
            int secondsNow = dateTime.Second;
            if (secondsNow != p_SecondsNow)
            {
                SecondsNow = p_SecondsNow = secondsNow;
                if ((p_SecondsNow > Config.HighlightSecondsValue) && (Config.HighlightSeconds))
                {
                    CurrentSecondsBarColor = Config.SelectedSecondsBarForgroundHighlightColor.Brush;
                }
                else
                {
                    CurrentSecondsBarColor = Config.SelectedSecondsBarForgroundColor.Brush;
                }
            }

        }

        private void Button_Setup_Click(object sender, RoutedEventArgs e)
        {
            DilogSetup setup = new DilogSetup();
            setup.ShowDialog();
            if (setup.DialogCloseAction == DilogSetup.DialogCloseType.Exit)
            {
                Close();
            }
            this.Left = Config.Left;
            this.Top = Config.Top;
        }

        private void Time_Now_Display_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            Config.Top = this.Top;
            Config.Left = this.Left;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Config.SaveCurrentStateToDefaults();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            if (Profile == null)
            {
                Config.LoadDefaults();
            }
            else
            {
                Config.UserProfileLoad(Profile);
            }
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();

        }
    }
}
