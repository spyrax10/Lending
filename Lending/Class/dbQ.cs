using System;
using System.Collections.Generic;
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

        public static void chkLogIn(TextBox usrTB, TextBox pass, TextBox pass2, 
            Label info, Panel pane)
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
                        pass.Focus();
                    }
                    else
                    {
                        info.Visible = false;
                        if (misc.passMatch(pass, pass2) == false)
                        {
                            info.Visible = true;
                            info.ForeColor = Color.Red;
                            info.Text = "Password Don't Match!";
                            pass2.Text = ""; pass2.Focus();
                        }
                        else
                        {
                            info.Visible = false;
                            using (var con = misc.getCon())
                            {
                                using (var cmd = con.CreateCommand())
                                {
                                    con.Open();
                                    cmd.CommandText = "SELECT * FROM [lendDB].[dbo].[usrTB] " +
                                        "WHERE Username = @user AND Password = @pass";
                                    
                                    using (var dr = cmd.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {
                                            mainFrm ma = new mainFrm();
                                            ma.Show();
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
