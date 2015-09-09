using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PhotoInfo.Other
{
    class AppConfigParser
    {
        private String confFileName;


        private AppConfigParser()
        {
            settings = new XmlDocument();
            this.confFileName = Application.ExecutablePath + ".config";
            try{
                settings.Load(this.confFileName);
            }
            catch(Exception e){
            
                SmartISLib.Messages.Error(e.StackTrace);///TODO -  development only
            
            }
        }

        private static AppConfigParser singleton = null;

        /// <summary>
        /// Singleton
        /// </summary>
        public static AppConfigParser getInstance
        {
            get
            {
                if (singleton == null)
                    singleton =  new AppConfigParser();
                return singleton;
            }
        }


        private XmlDocument settings;
        /// <summary>
        /// Get xml settings from app.config
        /// </summary>
        /// <param name="settingsName"></param>
        /// <returns>element value</returns>
        private XmlNode GetSettingsNode(string settingsName)
        {
            try
            {
                XmlNode node = settings["configuration"]["applicationSettings"].ChildNodes[0];
                foreach (XmlNode settingsNode in node.ChildNodes)
                {
                    if (settingsNode.Attributes["name"] != null &&
                        settingsNode.Attributes["name"].Value == settingsName)
                        return settingsNode["value"];
                }
            }
            catch (Exception ex)
            {
                SmartISLib.Exceptions.Handle(ex);
            }

            return null;
        }

        /// <summary>
        /// Connection string to database
        /// </summary>
        public string ConnectionString
        {
            get
            {
                XmlNode node = GetSettingsNode("ConnectionString");
                if (node == null)
                    Console.WriteLine("Fucking hell!");
                return node.InnerText;
            }
        }
    }
}
