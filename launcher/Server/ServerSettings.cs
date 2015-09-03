using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace luncher
{
    /// <summary>
    /// This class will contain all the necessary settings
    /// for a station. Each station will have an instance
    /// of this object and will be able to change its settings
    /// via the settings page.
    /// </summary>
    public class ServSettings
    {
        private int port;
        private int bitRate;
        private bool isStereo;

        #region public getters and setters

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public int BitRate
        {
            get { return bitRate; }
            set { bitRate = value; }
        }

        public bool IsStereo
        {
            get { return isStereo; }
            set { isStereo = value; }
        }

        #endregion

        public ServSettings() : this(8000, 96, false)
        { }

        public ServSettings(int prt, int brate, bool isSter)
        {
            port = prt;
            bitRate = brate;
            isStereo = isSter;
        }

        //used to save the users settings on the local machine
        public Boolean SaveServerSettings()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ServSettings));
            XmlTextWriter tr = new XmlTextWriter("ServerSettings.xml", null);

            xs.Serialize(tr, this);
            return true;
        }

        /// <summary>
        /// Used to recover the users server settings
        /// </summary>
        /// <returns>server settings</returns>
        public ServSettings GetServerSettings()
        {
            ServSettings settings = new ServSettings();

            XmlSerializer xs = new XmlSerializer(typeof(ServSettings));
            XmlTextReader tr = new XmlTextReader("ServerSettings.xml");
            if (tr != null)
            {
                settings = (ServSettings)xs.Deserialize(tr);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return settings;
        }
    }
}
