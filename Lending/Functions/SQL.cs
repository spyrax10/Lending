using Lending.Class;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Lending.Functions
{
    public static class SQL
    {
        public static void addCountTB(string sql)
        {
            try
            {
                string path = File.ReadAllText(@"..\..\Scripts\countTB(" + sql + ").sql");

                IEnumerable<string> cmd = Regex.Split(path, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);

                using (var con = SQL.getConnection())
                {
                    con.Open();
                    foreach (string commandString in cmd)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, con))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    Notification.Success("Application Settings Saved...");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                AppSettings.delAppSettings();
                Notification.Error(e.Message);
            }
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
                        sqlName.Add(Environment.MachineName);
                        sqlName.Add(Environment.MachineName + "\\" + instanceName);
                    }
                }
            }
            return sqlName;
        }

        public static string SQLversion()
        {
            string version = "";

            try
            {
                using (var con = getConnection())
                {
                    con.Open();
                    
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = 
                            @"SELECT CASE 
	                            WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 9 THEN 'SQL05'
	                            WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 10 THEN 'SQL08'
	                            WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 11 THEN 'SQL12'
	                            WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 12 THEN 'SQL14'
	                            WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 13 THEN 'SQL16'
	                            WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 14 THEN 'SQL17'
                                WHEN CAST(SERVERPROPERTY('ProductMajorVersion') AS INT) = 15 THEN 'SQL19'
                            END AS 'Version';";

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                version = dr.GetString(0);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }

            return version;
        }

        public static string DBbackupName()
        {
            return Extra.backpath + @"\LENDDB_" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";
        }

        public static bool connectionOpen()
        {
            bool stat = false;

            try
            {
                var con = getConnection();
                con.Open();
                stat = true;
            }
            catch
            {
                stat = false;
            }
            return stat;
        }

        public static SqlConnection getConnection()
        {
            var con = new SqlConnection();
            con.ConnectionString = connectionString();
            return con;
        }

        public static string connectionString()
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
    }
}
