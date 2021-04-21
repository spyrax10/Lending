using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending.Class
{
    public class misc
    {
        public static void invMsg(string msg)
        {
            MessageBox.Show(msg, " Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void errMsg(string msg)
        {
            MessageBox.Show(msg, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void sucMsg(string msg)
        {
            MessageBox.Show(msg, " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool isEmptyFields(Control comp)
        {
            if (comp.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)) ||
               comp.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool conStat()
        {
            bool stat = false;

            try
            {
                var con = getCon();
                con.Open();
                stat = true;
            }
            catch (Exception e)
            {
                stat = false;
                delAppSettings();
            }
            return stat;
        }

        public static SqlConnection getCon()
        {
            var con = new SqlConnection();
            con.ConnectionString = chkCon();
            return con;
        }

        public static string chkCon()
        {
            var con = "";
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["defCon"].ConnectionString;

                if (cs != null)
                {
                    con = cs;
                }
            }
            catch
            {
                con = "";
            }

            return con;
        }

        public static List<string> getSql()
        {
            List<string> sqlName = new List<string>();

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        sqlName.Add(Environment.MachineName + @"\" + instanceName);
                    }
                }
            }
            return sqlName;
        }

        public static string pathFinder()
        {
            var diag = new FolderBrowserDialog();
            string pName;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                pName = diag.SelectedPath + "\\";
            }
            else
            {
                pName = "";
            }
            return pName;
        }

        public static bool isRunAdm()
        {
            // Get current Windows user
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();

            // Get current Windows user principal
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);

            // Return TRUE if user is in role "Administrator"
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public static void runAdm()
        {
            try
            {
                if (!isRunAdm())
                {
                    // Setting up start info of the new process of the same application
                    ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);

                    // Using operating shell and setting the ProcessStartInfo.Verb to “runas” will let it run as admin
                    processStartInfo.UseShellExecute = true;
                    processStartInfo.Verb = "runas";

                    // Start the application as new process
                    Process.Start(processStartInfo);

                    // Shut down the current (old) process
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                errMsg(e.Message);
                Application.Exit();
            }
        }

        public static void appSettings(string server, string user, string pass, string path, CheckBox chk)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            config.ConnectionStrings.ConnectionStrings.Remove("defCon");
            config.AppSettings.Settings.Remove("Server");
            config.AppSettings.Settings.Remove("User");
            config.AppSettings.Settings.Remove("Hash");
            config.AppSettings.Settings.Remove("FoldPath");
            
            if (chk.Checked == true)
            {
                config.ConnectionStrings.ConnectionStrings.Add
                (new ConnectionStringSettings("defCon", "Data Source=" + server + ";Initial Catalog=master;Integrated Security=True;" +
                "MultipleActiveResultSets = True;"));
            }
            else if (chk.Checked == false)
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
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void delAppSettings()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            config.ConnectionStrings.ConnectionStrings.Remove("defCon");
            config.AppSettings.Settings.Remove("Server");
            config.AppSettings.Settings.Remove("User");
            config.AppSettings.Settings.Remove("Hash");
            config.AppSettings.Settings.Remove("FoldPath");

            config.Save(ConfigurationSaveMode.Full, false);
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
