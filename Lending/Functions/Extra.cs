using Lending.Functions;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lending.Class
{

    public class Extra
    {
        public static string logIn = "LOGIN";
        public static string logOut = "LOGOUT";
        public static string upD = "UPDATE";
        public static string rev = "REVERT";
        public static string exp = "EXPORT";
        public static string del = "DELETE";
        public static string imgLoc = "";
        

        public static string mainpath = @"..\..\Logs";
        public static string backpath = mainpath + @"\Backup";

        public static void setFileReadOnly(string file, bool readOnly = true)
        {
            if (readOnly)
            {
                File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.ReadOnly);
            }
            else
            {
                File.SetAttributes(file, File.GetAttributes(file) & ~FileAttributes.ReadOnly);
            }
        }

        public static void createLogFolder()
        {
            if (!Directory.Exists(mainpath))
            {
                Directory.CreateDirectory(mainpath);
            }

            if (!Directory.Exists(backpath))
            {
                Directory.CreateDirectory(backpath);
            }

            createLogFile("[Success]Program Started...");
        }

        public static void createLogFile(string msg = "")
        {
            string file = mainpath + @"\Log.txt";

            if (!File.Exists(file))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]" +
                    "[" + AppSettings.ip + "]" +
                        "[" + Environment.UserName + "||" + AppSettings.pc + "] " +
                        msg
                    );
                }

                setFileReadOnly(file);
            }
            else
            {
                setFileReadOnly(file, false);

                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]" +
                        "[" + AppSettings.ip + "]" +
                        "[" + Environment.UserName + "||" + AppSettings.pc + "] " +
                        msg
                    );
                }

                setFileReadOnly(file);
            }
        }

        public static void selImg(PictureBox img)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tif;...";
            dlg.Title = "Select a Photo";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                img.ImageLocation = imgLoc;
            }
        }

        public static object imgSelection()
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            return img = br.ReadBytes((int)fs.Length);
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

        public static bool isAdministrator()
        {
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();

            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);

            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void runAsAdministrator()
        {
            try
            {
                if (!isAdministrator())
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);

                    processStartInfo.UseShellExecute = true;
                    processStartInfo.Verb = "runas";

                    Process.Start(processStartInfo);
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);            }
        }
    }
}
