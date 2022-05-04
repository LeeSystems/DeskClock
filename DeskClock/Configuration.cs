using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.IO;

namespace DeskClock
{
    public class Configuration : INotifyPropertyChanged
    {
        public MainWindow DeskClockWindow { set; get; }
        public static String defaultProfileName = @"DefaultProfile";

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public BrushColorItems BrushList { get; set; }
        public ObservableCollection<String> ProfileList { private set;  get; }
        public ReadOnlyCollection<TimeZoneInfo> TimeZoneList { private set; get; }

        private TimeZoneInfo p_TimeZoneSelected;
        public TimeZoneInfo TimeZoneSelected
        {
            get
            {
                return p_TimeZoneSelected;
            }
            set
            {
                p_TimeZoneSelected = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TimeZoneSelected"));
            }
        }

        private Double p_Top;
        public Double Top
        {
            get
            {
                return p_Top;
            }
            set
            {
                Double sepValue = value;
                Double height = System.Windows.SystemParameters.VirtualScreenHeight;
                Double winHight;
                if ( DeskClockWindow == null)
                {
                    winHight = 100;
                }
                else
                {
                    winHight = DeskClockWindow.Height;
                }

                if (sepValue > (height - winHight)) sepValue = ((height /2) - winHight);  
                p_Top = sepValue;
                DeskClockWindow.Top = sepValue;
                PropertyChanged(this, new PropertyChangedEventArgs("Top"));
            }
        }

        private Double p_Left;
        public Double Left
        {
            get
            {
                return p_Left;
            }
            set
            {
                Double sepValue = value;
                Double width = System.Windows.SystemParameters.VirtualScreenWidth;
                Double winWidth;
                if (DeskClockWindow == null)
                {
                    winWidth = 100;
                }
                else
                {
                    winWidth = DeskClockWindow.Width;
                }

                if (sepValue > (width - winWidth)) sepValue = ((width / 2) - winWidth);
                p_Left = sepValue;
                DeskClockWindow.Left = sepValue;
                PropertyChanged(this, new PropertyChangedEventArgs("Left"));
            }
        }

        private String p_WindowTitle;
        public String WindowTitle
        {
            get
            {
                return p_WindowTitle;
            }
            set
            {
                p_WindowTitle = value;
                PropertyChanged(this, new PropertyChangedEventArgs("WindowTitle"));
            }
        }

        private String p_ProfileNameLoaded;
        public String ProfileNameLoaded
        {
            get
            {
                return p_ProfileNameLoaded;
            }
            set
            {
                p_ProfileNameLoaded = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ProfileNameLoaded"));
            }
        }

        private String p_ProfileNameSelected;
        public String ProfileNameSelected
        {
            get
            {
                return p_ProfileNameSelected;
            }
            set
            {
                p_ProfileNameSelected = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ProfileNameSelected"));
            }
        }

        private Boolean p_TopWindow;
        public Boolean TopWindow
        {
            get
            {
                return p_TopWindow;
            }
            set
            {
                p_TopWindow = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TopWindow"));
            }
        }

        private Boolean p_ShowTitle;
        public Boolean ShowTitle
        {
            get
            {
                return p_ShowTitle;
            }
            set
            {
                p_ShowTitle = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ShowTitle"));
            }
        }

        private Boolean p_ShowDate;
        public Boolean ShowDate
        {
            get
            {
                return p_ShowDate;
            }
            set
            {
                p_ShowDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ShowDate"));
            }
        }


        private String p_TimeFormat;
        public String TimeFormat
        {
            get
            {
                return p_TimeFormat;
            }
            set
            {
                p_TimeFormat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TimeFormat"));
            }
        }

        private BrushColor p_SelectedTextColor;
        public BrushColor SelectedTextColor
        {
            get
            {
                return p_SelectedTextColor;
            }
            set
            {
                p_SelectedTextColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedTextColor"));
            }
        }

        private BrushColor p_SelectedTextBackgroundColor;
        public BrushColor SelectedTextBackgroundColor
        {
            get
            {
                return p_SelectedTextBackgroundColor;
            }
            set
            {
                p_SelectedTextBackgroundColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedTextBackgroundColor"));
            }
        }

        private Boolean p_ShowSecondsBar;
        public Boolean ShowSecondsBar
        {
            get
            {
                return p_ShowSecondsBar;
            }
            set
            {
                p_ShowSecondsBar = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ShowSecondsBar"));
            }
        }

        private int p_SecondsBarHeight;
        public int SecondsBarHeight
        {
            get
            {
                return p_SecondsBarHeight;
            }
            set
            {
                p_SecondsBarHeight = value;
                if (p_SecondsBarHeight > 100) p_SecondsBarHeight = 100;
                if (p_SecondsBarHeight < 0) p_SecondsBarHeight = 0;
                PropertyChanged(this, new PropertyChangedEventArgs("SecondsBarHeight"));
            }
        }

        private Boolean p_HighlightSeconds;
        public Boolean HighlightSeconds
        {
            get
            {
                return p_HighlightSeconds;
            }
            set
            {
                p_HighlightSeconds = value;
                PropertyChanged(this, new PropertyChangedEventArgs("HighlightSeconds"));
            }
        }

        private int p_HighlightSecondsValue;
        public int HighlightSecondsValue
        {
            get
            {
                return p_HighlightSecondsValue;
            }
            set
            {
                p_HighlightSecondsValue = value;
                if (p_HighlightSecondsValue > 59) p_HighlightSecondsValue = 59;
                if (p_HighlightSecondsValue < 0) p_HighlightSecondsValue = 0;
                PropertyChanged(this, new PropertyChangedEventArgs("HighlightSecondsValue"));
            }
        }

        private BrushColor p_SelectedSecondsBarBackgroundColor;
        public BrushColor SelectedSecondsBarBackgroundColor
        {
            get
            {
                return p_SelectedSecondsBarBackgroundColor;
            }
            set
            {
                p_SelectedSecondsBarBackgroundColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedSecondsBarBackgroundColor"));
            }
        }

        private BrushColor p_SelectedSecondsBarForgroundColor;
        public BrushColor SelectedSecondsBarForgroundColor
        {
            get
            {
                return p_SelectedSecondsBarForgroundColor;
            }
            set
            {
                p_SelectedSecondsBarForgroundColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedSecondsBarForgroundColor"));
            }
        }

        private BrushColor p_SelectedSecondsBarForgroundHighlightColor;
        public BrushColor SelectedSecondsBarForgroundHighlightColor
        {
            get
            {
                return p_SelectedSecondsBarForgroundHighlightColor;
            }
            set
            {
                p_SelectedSecondsBarForgroundHighlightColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedSecondsBarForgroundHighlightColor"));
            }
        }

        private Double p_DateFontSizeValue;
        public Double DateFontSizeValue
        {
            get
            {
                return p_DateFontSizeValue;
            }
            set
            {
                p_DateFontSizeValue = value;
                if (p_DateFontSizeValue > 100) p_DateFontSizeValue = 100;
                if (p_DateFontSizeValue < 0) p_DateFontSizeValue = 10;
                PropertyChanged(this, new PropertyChangedEventArgs("DateFontSizeValue"));
            }
        }

        private Double p_TitleFontSizeValue;
        public Double TitleFontSizeValue
        {
            get
            {
                return p_TitleFontSizeValue;
            }
            set
            {
                p_TitleFontSizeValue = value;
                if (p_TitleFontSizeValue > 100) p_TitleFontSizeValue = 100;
                if (p_TitleFontSizeValue < 0) p_TitleFontSizeValue = 10;
                PropertyChanged(this, new PropertyChangedEventArgs("TitleFontSizeValue"));
            }
        }


        private Double p_FontSizeValue;
        public Double FontSizeValue
        {
            get
            {
                return p_FontSizeValue;
            }
            set
            {
                p_FontSizeValue = value;
                if (p_FontSizeValue > 100) p_FontSizeValue = 100;
                if (p_FontSizeValue < 0) p_FontSizeValue = 10;
                PropertyChanged(this, new PropertyChangedEventArgs("FontSizeValue"));
            }
        }

        private String ProfileFolder;


        public Configuration()
        {
            BrushList = new BrushColorItems();
            ProfileList = new ObservableCollection<string>();
            ProfileFolder = Environment.ExpandEnvironmentVariables(@"%APPDATA%\Lee Systems\DeskClock");
            Directory.CreateDirectory(ProfileFolder);
            LoadProfileList();
            GetTimeZoneList();
            //LoadDefaults();
            //SetDefaults();
        }

        public void LoadDefaults()
        {
            String profileFile = ProfileFilePath(defaultProfileName);
            if (File.Exists(profileFile))
            {
                // Load Profile
                UserProfileLoad(defaultProfileName);
            }
            else
            {
                SetDefaults();
            }
        }

        public void SetDefaults()
        {
            // Set Defaults
            TimeZoneSelected = GetTimeZone(String.Empty);
            ShowDate = true;
            ShowTitle = true;
            SelectedTextColor = BrushList.GetBrushColor("Blue");
            SelectedTextBackgroundColor = BrushList.GetBrushColor("Transperent");
            SelectedSecondsBarBackgroundColor = BrushList.GetBrushColor("Transperent");
            SelectedSecondsBarForgroundColor = BrushList.GetBrushColor("Green");
            SelectedSecondsBarForgroundHighlightColor = BrushList.GetBrushColor("Red"); ;
            WindowTitle = @"Desk Clock";
            TopWindow = false;
            ShowSecondsBar = true;
            SecondsBarHeight = 10;
            HighlightSeconds = true;
            HighlightSecondsValue = 50;
            FontSizeValue = 40;
            DateFontSizeValue = 10;
            TitleFontSizeValue = 10;
            TimeFormat = "hh:mm:ss";
            // get scerrn size
            //Top = 100;
            //Left = 100;
            // write out defaults
            UserProfileSave(defaultProfileName);

        }

        public void SaveCurrentStateToDefaults()
        {
            UserProfileSave(defaultProfileName);
        }

        public void UserProfileLoad(String profileName)
        {
            try
            {
                DeskClockProfileFile deskClockProfileFile = new DeskClockProfileFile(ProfileFilePath(profileName));
                // Window
                WindowTitle = deskClockProfileFile.UserProfile.Name;
                TopWindow = false;
                if ( deskClockProfileFile.UserProfile.AllwaysOnTopSpecified)
                {
                    TopWindow = deskClockProfileFile.UserProfile.AllwaysOnTop;
                }
                Top = deskClockProfileFile.UserProfile.WindowPosition.Vertical;
                Left = deskClockProfileFile.UserProfile.WindowPosition.Horizontal;
                // Time Display
                TimeZoneSelected = GetTimeZone(deskClockProfileFile.UserProfile.TimeDisplay.TimeZone);
                ShowTitle = deskClockProfileFile.UserProfile.TimeDisplay.TitleEnable;
                TitleFontSizeValue = deskClockProfileFile.UserProfile.TimeDisplay.TitleFountSize;
                ShowDate = deskClockProfileFile.UserProfile.TimeDisplay.DateEnable;
                DateFontSizeValue = deskClockProfileFile.UserProfile.TimeDisplay.DateFountSize;
                SelectedTextColor = BrushList.GetBrushColor(deskClockProfileFile.UserProfile.TimeDisplay.ForgroundColor);
                SelectedTextBackgroundColor = BrushList.GetBrushColor(deskClockProfileFile.UserProfile.TimeDisplay.BackgroundColor);
                FontSizeValue = deskClockProfileFile.UserProfile.TimeDisplay.ClockFountSize;
                // Seconds Bar
                ShowSecondsBar = deskClockProfileFile.UserProfile.SecondsBar.Visable;
                SecondsBarHeight = deskClockProfileFile.UserProfile.SecondsBar.BarHeight;
                HighlightSeconds = deskClockProfileFile.UserProfile.SecondsBar.HighlightEnable;
                HighlightSecondsValue = deskClockProfileFile.UserProfile.SecondsBar.HiglightAfter;
                SelectedSecondsBarBackgroundColor = BrushList.GetBrushColor(deskClockProfileFile.UserProfile.SecondsBar.BackgroundColor);
                SelectedSecondsBarForgroundColor = BrushList.GetBrushColor(deskClockProfileFile.UserProfile.SecondsBar.ForgroundColor);
                SelectedSecondsBarForgroundHighlightColor = BrushList.GetBrushColor(deskClockProfileFile.UserProfile.SecondsBar.HighlightColor);
                ProfileNameLoaded = profileName;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(String.Format("ERROR - {0}", ex.Message ),
                    "Error" , System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }        
        }

        public void UserProfileSave(String profileName)
        {
            try
            {
                DeskClockProfileFile deskClockProfileFile = new DeskClockProfileFile();
                deskClockProfileFile.UserProfile = new DeskClockProfile();
                // Window
                deskClockProfileFile.UserProfile.Name = WindowTitle;
                deskClockProfileFile.UserProfile.AllwaysOnTop = TopWindow;
                deskClockProfileFile.UserProfile.AllwaysOnTopSpecified = true;
                deskClockProfileFile.UserProfile.WindowPosition = new DeskClockProfileWindowPosition();
                // Time Display
                deskClockProfileFile.UserProfile.TimeDisplay = new DeskClockProfileTimeDisplay();
                deskClockProfileFile.UserProfile.TimeDisplay.TitleEnable = ShowTitle;
                deskClockProfileFile.UserProfile.TimeDisplay.TitleFountSize = TitleFontSizeValue;
                deskClockProfileFile.UserProfile.TimeDisplay.DateEnable = ShowDate;
                deskClockProfileFile.UserProfile.TimeDisplay.DateFountSize = DateFontSizeValue;
                deskClockProfileFile.UserProfile.TimeDisplay.TimeZone = TimeZoneSelected.DisplayName;
                deskClockProfileFile.UserProfile.TimeDisplay.ForgroundColor = SelectedTextColor.Name;
                deskClockProfileFile.UserProfile.TimeDisplay.BackgroundColor = SelectedTextBackgroundColor.Name;
                deskClockProfileFile.UserProfile.TimeDisplay.ClockFountSize = FontSizeValue;
                // Seconds Bar
                deskClockProfileFile.UserProfile.SecondsBar = new DeskClockProfileSecondsBar();
                deskClockProfileFile.UserProfile.SecondsBar.Visable = ShowSecondsBar;
                deskClockProfileFile.UserProfile.SecondsBar.BarHeight = SecondsBarHeight;
                deskClockProfileFile.UserProfile.SecondsBar.HighlightEnable = HighlightSeconds;
                deskClockProfileFile.UserProfile.SecondsBar.HiglightAfter = HighlightSecondsValue;
                deskClockProfileFile.UserProfile.SecondsBar.BackgroundColor = SelectedSecondsBarBackgroundColor.Name;
                deskClockProfileFile.UserProfile.SecondsBar.ForgroundColor = SelectedSecondsBarForgroundColor.Name;
                deskClockProfileFile.UserProfile.SecondsBar.HighlightColor = SelectedSecondsBarForgroundHighlightColor.Name;
                // set Posistion
                deskClockProfileFile.UserProfile.WindowPosition.Vertical = Top;
                deskClockProfileFile.UserProfile.WindowPosition.Horizontal = Left;

                deskClockProfileFile.Write(ProfileFilePath(profileName));
                ProfileNameLoaded = profileName;
                LoadProfileList();

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(String.Format("ERROR - {0}", ex.Message),
                    "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        public void LoadProfileList()
        {
            try
            {
                ProfileList.Clear();
                foreach (String name in Directory.GetFiles(ProfileFolder))
                {
                    if (Path.GetExtension(name) == ".xml")
                    {
                        String profileName = Path.GetFileNameWithoutExtension(name);
                        ProfileList.Add(profileName);
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(String.Format("ERROR - {0}", ex.Message),
                    "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        public void DeleteProfile(String profileName)
        {
            File.Delete(ProfileFilePath(profileName));
            LoadProfileList();
        }

        public String ProfileFilePath(String profileName)
        {
            String profileFile = Path.Combine(ProfileFolder, profileName);
            return Path.ChangeExtension(profileFile, "xml");
        }

        public Boolean IsProfileNameValid(String profileName)
        {
            Boolean isValid = (!String.IsNullOrEmpty(profileName)) &&
              (profileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 );
            return isValid;
        }

        public Boolean IsProfileNameExisting(String profileName)
        {
            Boolean isValid = (!String.IsNullOrEmpty(profileName)) &&
              (profileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0);
            if(isValid)
            {
                String profileFile = ProfileFilePath(profileName);
                if (File.Exists(profileFile))
                {
                    return true;
                }

            }
            return false;
        }

        public void GetTimeZoneList()
        {
            TimeZoneList = TimeZoneInfo.GetSystemTimeZones();
        }

        public TimeZoneInfo GetTimeZone(String timeZoneDisplayName)
        {
            foreach (TimeZoneInfo tzi in TimeZoneList)
            {
                if ( tzi.DisplayName == timeZoneDisplayName)
                {
                    return tzi;
                }
            }
            return TimeZoneInfo.Local;
        }
    }
}
