﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending.Class
{
    public class dbQ
    {
        [Obsolete]
        public static void log(int id, string action, string table, string transId, 
            string orig, string val)
        {
            try
            {
                using (var con = misc.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "INSERT INTO [lendDB].[dbo].[logTB] VALUES (@id, @date, @time, @ip, @pc, " +
                            "@action, @table, @transID, @orig, @val)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@ip", misc.ip);
                        cmd.Parameters.AddWithValue("@pc", misc.pc);
                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@table", table);
                        cmd.Parameters.AddWithValue("@transID", transId);
                        cmd.Parameters.AddWithValue("@orig", orig);
                        cmd.Parameters.AddWithValue("@val", val);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }
        }

        public static void loadCount(ComboBox cB)
        {
            try
            {
                using (var con = misc.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT DISTINCT [Country] " +
                            "FROM [lendDB].[dbo].[countTB] " +
                            "ORDER BY [Country] ASC";
                        
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Country"].ToString());
                                Application.DoEvents();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }
        }

        public static void loadPro(ComboBox count, ComboBox cB)
        {
            try
            {
                cB.Text = "";
                cB.Items.Clear();

                using (var con = misc.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT DISTINCT [Province] " +
                            "FROM [lendDB].[dbo].[countTB] " +
                            "WHERE [Country] = @count " +
                            "ORDER BY [Province] ASC";
                        cmd.Parameters.AddWithValue("@count", count.Text);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Province"].ToString());
                                Application.DoEvents();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }
        }

        public static void loadMun(ComboBox count, ComboBox pro, ComboBox cB)
        {
            try
            {
                cB.Text = ""; cB.Items.Clear();

                using (var con = misc.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = cmd.CommandText = "SELECT DISTINCT [Municipality] " +
                            "FROM [lendDB].[dbo].[countTB] " +
                            "WHERE [Country] = @count AND [Province] = @pro " +
                            "ORDER BY [Municipality] ASC";
                        cmd.Parameters.AddWithValue("@count", count.Text);
                        cmd.Parameters.AddWithValue("@pro", pro.Text);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Municipality"].ToString());
                                Application.DoEvents();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }
        }

        public static void loadBar(ComboBox count, ComboBox pro, ComboBox mun, ComboBox cB)
        {
            try
            {
                cB.Text = ""; cB.Items.Clear();

                using (var con = misc.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = "SELECT DISTINCT [Barangay] " +
                            "FROM [lendDB].[dbo].[countTB] " +
                            "WHERE [Country] = @count AND [Province] = @pro AND [Municipality] = @mun " +
                            "ORDER BY [Barangay] ASC";
                        cmd.Parameters.AddWithValue("@count", count.Text);
                        cmd.Parameters.AddWithValue("@pro", pro.Text);
                        cmd.Parameters.AddWithValue("@mun", mun.Text);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Barangay"].ToString());
                                Application.DoEvents();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }
        }

        public static void chkLogIn(TextBox usrTB, TextBox pass, TextBox pass2, 
            Label info, Panel pane, Form log)
        {
            try
            {
                if (misc.isEmptyFields(pane) == true)
                {
                    misc.invMsg("Missing Fields!");
                }
                else
                {
                    if (misc.valPass(pass.Text) == false)
                    {
                        info.Visible = true;
                        info.ForeColor = Color.Red;
                        info.Text = "Invalid Format! e.g.(Abcde12)";
                        pass.Text = ""; pass2.Text = ""; pass.Focus();
                    }
                    else
                    {
                        info.Visible = false;
                        if (misc.passMatch(pass, pass2) == false)
                        {
                            info.Visible = true;
                            info.ForeColor = Color.Red;
                            info.Text = "Password Don't Match!";
                            pass2.Text = ""; pass.Focus();
                        }
                        else
                        {
                            info.Visible = false;

                            if (misc.sqlStat(ConfigurationManager.AppSettings["SQL"].ToString()) == false)
                                misc.agentSC(ConfigurationManager.AppSettings["SQL"].ToString()).Start();

                            using (var con = misc.getCon())
                            {
                                using (var cmd = con.CreateCommand())
                                {
                                    con.Open();
                                    cmd.CommandText = "SELECT * FROM [lendDB].[dbo].[usrTB] " +
                                        "WHERE Username = @user AND Password = @pass";
                                    cmd.Parameters.AddWithValue("@user", usrTB.Text);
                                    cmd.Parameters.AddWithValue("@pass", misc.GetMD5(pass.Text));

                                    using (var dr = cmd.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {
                                            mainFrm ma = new mainFrm();
                                            ma.Show(); misc.clrCont(pane);
                                            log.Hide(); log.ShowInTaskbar = false;
                                        }
                                        else
                                        {
                                            misc.errMsg("Incorrect Credentials!");
                                            pass.Text = ""; pass2.Text = ""; pass.Focus();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }
        }
    }
}
