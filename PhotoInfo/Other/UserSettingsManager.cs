using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Other
{
    class UserSettingsManager : SmartISLib.Interfaces.IUserSettingsManager
    {

        string SmartISLib.Interfaces.IUserSettingsManager.GetSetting(string key)
        {
            return null;//TODO
        }

        bool SmartISLib.Interfaces.IUserSettingsManager.HasSetting(string key)
        {
            return false;//TODO
        }

        void SmartISLib.Interfaces.IUserSettingsManager.SetSetting(string key, string value)
        {
            //TODO
        }
    }
}
