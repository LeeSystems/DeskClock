using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeskClock
{
    public class DeskClockProfileFile
    {
        #region Properties

        public DeskClockProfile UserProfile { get; set; }
        public String FileName { get; set; }

        #endregion

        #region Constructors

        public DeskClockProfileFile()
        {

        }

        public DeskClockProfileFile(String filePath)
        {
            UserProfile = Read(filePath);
        }

        #endregion

        #region Methods

        public DeskClockProfile Read(String filePath)
        {
            FileName = filePath;
            try
            {
                UserProfile = new DeskClockProfile();
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(DeskClockProfile));
                using (StreamReader file = new StreamReader(File.OpenRead(filePath)))
                {
                    UserProfile = reader.Deserialize(file) as DeskClockProfile;
                }
            }
            catch (Exception e)
            {
                throw new Exception(@"Error Reading Profile file: '" + filePath + @"'", e);
            }
            return UserProfile;
        }

        public void Write(String filePath)
        {
            try
            {
                // write to XML file
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(UserProfile.GetType());
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    writer.Serialize(file, UserProfile);
                }
            }
            catch (Exception e)
            {
                throw new Exception(@"Error Writing Profile file: '" + filePath + @"'", e);
            }

        }

        #endregion
    }
}
