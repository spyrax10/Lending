
using System.Net;
using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace Lending.Functions
{
    public static class AppSettings
    {

        [Obsolete]
        public static string ip = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();
        public static string pc = Environment.MachineName;

        public static void appSettings(string server, string user, string pass, string path, bool useAuthen = false)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

            delAppSettings();

            if (useAuthen)
            {
                config.ConnectionStrings.ConnectionStrings.Add
                (new ConnectionStringSettings("defCon", "Data Source=" + server + ";Initial Catalog=master;Integrated Security=True;" +
                "MultipleActiveResultSets = True;"));
            }
            else
            {
                config.ConnectionStrings.ConnectionStrings.Add
                (new ConnectionStringSettings("defCon", "Data Source=" + server + ";Initial Catalog=master;Persist Security Info=True;" +
                    "User ID=" + user + ";Password=" + pass + ";MultipleActiveResultSets = True;"));
            }

            config.AppSettings.Settings.Add("Server", server);
            config.AppSettings.Settings.Add("User", user);
            config.AppSettings.Settings.Add("Hash", pass);
            config.AppSettings.Settings.Add("FoldPath", path);

            config.Save(ConfigurationSaveMode.Full, false);

            config.AppSettings.Settings.Add("SQL", SQL.SQLversion());

            config.Save(ConfigurationSaveMode.Full, false);

            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void delAppSettings()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            config.ConnectionStrings.ConnectionStrings.Remove("defCon");
            config.AppSettings.Settings.Remove("Server");
            config.AppSettings.Settings.Remove("User");
            config.AppSettings.Settings.Remove("SQL");
            config.AppSettings.Settings.Remove("Hash");
            config.AppSettings.Settings.Remove("FoldPath");

            config.Save(ConfigurationSaveMode.Full, false);
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
