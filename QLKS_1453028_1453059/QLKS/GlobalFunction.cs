using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLKS
{
    public static class GlobalFunction
    {
        public static void UpdateAppSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string ReadAppSetting(string key)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //string Val = config.AppSettings.Settings[key].Value;
            string Val = System.Configuration.ConfigurationManager.AppSettings[key];
            return Val;
        }
    }
}
