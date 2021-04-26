using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Lending.Class
{
    
    public class misc
    {
        
        [Obsolete]
        public static string ip = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();
        public static string pc = Environment.MachineName;

        public static string logIn = "LOGIN";
        public static string logOut = "LOGOUT";
        public static string upD = "UPDATE";
        public static string rev = "REVERT";
        public static string exp = "EXPORT";
        public static string del = "DELETE";
        

        public static ServiceController agentSC(string sql) => new ServiceController("SQLAgent$" + sql + "", pc);
        public static ServiceController sqlSC(string sql) => new ServiceController("MSSQL$" + sql + "", pc);
       
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

        public static void addCountTB(string sql)
        {
            
            try
            {
                string path = File.ReadAllText(@"..\..\Scripts\countTB(" + sql + ").sql");

                IEnumerable<string> cmd = Regex.Split(path, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);

                using (var con = getCon())
                {
                    con.Open();
                    foreach (string commandString in cmd)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand (commandString, con))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                delAppSettings();
                errMsg(e.Message);
            }
        }

        public static bool sqlStat(string val)
        {
            return sqlSC(val).Status.Equals(ServiceControllerStatus.Running) && 
                agentSC(val).Status.Equals(ServiceControllerStatus.Running);
        }

        public static void stopSQL(string sql)
        {
            try
            {
                if (sqlStat(sql) == true)
                {
                    agentSC(sql).Stop(); sqlSC(sql).Stop();
                    sucMsg("Service Stop!");
                }
            }
            catch (Exception e)
            {
                errMsg(e.Message);
            }
        }

        public static void clrCont(Control comp)
        {
            comp.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            comp.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Text = "");
            comp.Controls.OfType<Panel>().ToList().ForEach(t => t.Text = "");

            foreach (Control c in comp.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control d in c.Controls)
                    {
                        if (d is TextBox)
                        {
                            d.Text = "";
                        }
                        if (d is ComboBox)
                        {
                            d.Text = "";
                        }
                        if (d is DataGridView)
                        {
                            d.Refresh();
                        }
                    }
                }
            }
        }

        public static bool passMatch(TextBox pass, TextBox pass2)
        {
            bool IsMatch = pass.Text == pass2.Text;
            if (IsMatch == false)
            {
                pass.Focus();
                pass.Text = "";
                pass2.Text = "";
            }
            return IsMatch;
        }

        public static bool valPass(string password)
        {
            string pat = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{5,}$";
            bool valid = Regex.IsMatch(password, pat);
            return valid;
        }

        public static bool valEmail(string email)
        {
            string _regexPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            bool stat = Regex.IsMatch(email, _regexPattern) == true && email != "";

            return stat;
        }

        public static void createFold()
        {
            try
            {
                string mainFold = ConfigurationManager.AppSettings["FoldPath"].ToString() + @"\Lending\";
                string repFold = mainFold + "_Excel";

                if (!Directory.Exists(mainFold))
                {
                    Directory.CreateDirectory(mainFold);
                }

                if (!Directory.Exists(repFold))
                {
                    Directory.CreateDirectory(repFold);
                }
            }
            catch (Exception e)
            {
                errMsg(e.Message);
            }
        }

        private static string chkFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (File.Exists(fileName))
            {
                if (i == 0)
                    fileName = fileName.Replace(extension, "(" + ++i + ")" + extension);
                else
                    fileName = fileName.Replace("(" + i + ")" + extension, "(" + ++i + ")" + extension);
            }

            return fileName;
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
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
                        sqlName.Add(Environment.MachineName + "\\" + instanceName);
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
                pName = diag.SelectedPath;
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
                Environment.Exit(0);
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
