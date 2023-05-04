using Lending.Functions;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lending.Class
{
    public class Query
    {
        [Obsolete]
        public static void log(int id, string action, string table, string transId, 
            string orig, string val)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "INSERT INTO [zzz_Lending].[dbo].[LOGTB] VALUES (@id, @date, @time, @ip, @pc, " +
                            "@action, @table, @transID, @orig, @val)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@ip", AppSettings.ip);
                        cmd.Parameters.AddWithValue("@pc", AppSettings.pc);
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
                Notification.Error(e.Message);
            }
        }

        public static void loadCount(ComboBox cB)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT DISTINCT [Country] " +
                            "FROM [zzz_Lending].[dbo].[countTB] " +
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
                Notification.Error(e.Message);
            }
        }

        public static void loadPro(ComboBox count, ComboBox cB)
        {
            try
            {
                cB.Text = "";
                cB.Items.Clear();

                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT DISTINCT [Province] " +
                            "FROM [zzz_Lending].[dbo].[countTB] " +
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
                Notification.Error(e.Message);
            }
        }

        public static void loadMun(ComboBox count, ComboBox pro, ComboBox cB)
        {
            try
            {
                cB.Text = ""; cB.Items.Clear();

                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = cmd.CommandText = "SELECT DISTINCT [Municipality] " +
                            "FROM [zzz_Lending].[dbo].[countTB] " +
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
                Notification.Error(e.Message);
            }
        }

        public static void loadBar(ComboBox count, ComboBox pro, ComboBox mun, ComboBox cB)
        {
            try
            {
                cB.Text = ""; cB.Items.Clear();

                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = "SELECT DISTINCT [Barangay] " +
                            "FROM [zzz_Lending].[dbo].[countTB] " +
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
                Notification.Error(e.Message);
            }
        }

        public static void viewCusImg(string cusId, PictureBox pB)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(Extra.imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT [cusId], [Photo] " +
                                    "FROM [zzz_Lending].[dbo].[CITB] " +
                                    "WHERE [cusId] = @cusId";
                        cmd.Parameters.AddWithValue("@cusId", cusId);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                img = (byte[])(dr["Photo"]);
                                MemoryStream ms = new MemoryStream(img);
                                pB.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
        }

        public static void dispCusDet(string sql, TextBox cusId, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox fb, ComboBox count, ComboBox pro, ComboBox mun, ComboBox bar, TextBox pur,
            TextBox bal, PictureBox pB, Button btn)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = sql;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                cusId.Text = dr["cusId"].ToString();
                                first.Text = dr["Firstname"].ToString();
                                mid.Text = dr["Midname"].ToString();
                                last.Text = dr["Lastname"].ToString();
                                mob.Text = dr["Phone"].ToString();
                                fb.Text = dr["FB"].ToString();
                                count.Text = dr["Country"].ToString();
                                pro.Text = dr["Province"].ToString();
                                mun.Text = dr["Municipality"].ToString();
                                bar.Text = dr["Barangay"].ToString();
                                pur.Text = dr["Street/Purok"].ToString();
                                bal.Text = dr["Balance"].ToString();
                                byte[] img = (byte[])(dr["Photo"]);

                                if (img != null)
                                {
                                    MemoryStream ms = new MemoryStream(img);
                                    pB.Image = Image.FromStream(ms);
                                }

                                bal.Enabled = false;
                                btn.Text = "UPDATE";
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
        }

        public static void viewCusDet(int val, TextBox cusId, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox fb, ComboBox count, ComboBox pro, ComboBox mun, ComboBox bar, TextBox pur,
            TextBox bal, PictureBox pB, Button btn)
        {
            try
            {
                int cnt = 0;

                string sqlQ = "SELECT * FROM [zzz_Lending].[dbo].[CITB] ";

                if (val == 1)
                {
                    sqlQ += "WHERE [cusId] IN (SELECT MAX(X.cusId) FROM [zzz_Lending].[dbo].[CITB] X) ";
                }
                else if (val == 2)
                {
                    sqlQ += "WHERE [cusId] IN (SELECT MIN(X.cusId) FROM [zzz_Lending].[dbo].[CITB] X) ";
                }
                else if (val == 3)
                {
                    cnt = Int32.Parse(cusId.Text) + 1;
                    sqlQ += "WHERE [cusId] = '" + cnt + "'";
                }
                else if (val == 4)
                {
                    cnt = Int32.Parse(cusId.Text) - 1;
                    sqlQ += "WHERE [cusId] = '" + cnt + "'";
                }

                dispCusDet(sqlQ, cusId, first, mid, last, mob, fb, 
                    count, pro, mun, bar, pur, bal, pB, btn);
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
        }

        public static void updCusImg(PictureBox pB, Button btn, TextBox cusId)
        {
            try
            {
                Extra.selImg(pB);

                using (var con = SQL.getConnection())
                {
                    con.Open();

                    if (btn.Text == "UPDATE")
                    {
                        if (MessageBox.Show("Update Avatar?", " Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                cmd.CommandText = "UPDATE [zzz_Lending].[dbo].[CITB] " +
                                    "SET [Photo] = @img WHERE [cusId] = @cusId";
                                cmd.Parameters.AddWithValue("@img", Extra.imgSelection());
                                cmd.Parameters.AddWithValue("@cusId", cusId.Text);
                                cmd.ExecuteNonQuery();
                                Notification.Success("Avatar Updated!");
                            }
                        }
                        else
                        {
                            viewCusImg(cusId.Text, pB);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
        }

        public static bool nameExist(string first, string mid, string last, string cusId)
        {
            bool stat = false;
            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM [zzz_Lending].[dbo].[CITB] " +
                            "WHERE [Firstname] = @first AND [Midname] = @mid AND [Lastname] = @last " +
                            "AND [cusId] <> @id";
                        cmd.Parameters.AddWithValue("@first", first);
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@last", last);
                        cmd.Parameters.AddWithValue("@id", cusId);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                stat = true;
                            }
                            else
                            {
                                stat = false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
            return stat;
        }

        public static void createCusInfo(Panel pane, TextBox first, TextBox mid, TextBox last, TextBox mob, TextBox fb, 
            ComboBox count, ComboBox pro, ComboBox mun, ComboBox bar, TextBox pur, TextBox bal, 
            Button but, TextBox cusId)
        {
            try
            {
                int id = 0;

                
                if (Extra.isEmptyFields(pane) == true)
                {
                    Notification.Invalid("Missing Fields!");
                }
                else
                {
                    using (var con = SQL.getConnection())
                    {
                        con.Open();

                        if (but.Text == "REGISTER")
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                cmd.CommandText = "SELECT ISNULL(MAX(A.cusId), 0) [cusId] " +
                                    "FROM [zzz_Lending].[dbo].[CITB] A";

                                using (var dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read())
                                    {
                                        id = Int32.Parse(dr["cusId"].ToString()) + 1;
                                    }

                                    using (var cmd2 = con.CreateCommand())
                                    {
                                        cmd2.CommandText = "INSERT INTO [zzz_Lending].[dbo].[CITB] VALUES ( " +
                                            "@cusId, @first, @mid, @last, @mob, @fb, @count, @pro, @mun, @bar, " +
                                            "@pur, @bal, @img)";
                                        cmd2.Parameters.AddWithValue("@cusId", id);
                                        cmd2.Parameters.AddWithValue("@first", first.Text);
                                        cmd2.Parameters.AddWithValue("@mid", mid.Text);
                                        cmd2.Parameters.AddWithValue("@last", last.Text);
                                        cmd2.Parameters.AddWithValue("@mob", mob.Text);
                                        cmd2.Parameters.AddWithValue("@fb", fb.Text);
                                        cmd2.Parameters.AddWithValue("@count", count.Text);
                                        cmd2.Parameters.AddWithValue("@pro", pro.Text);
                                        cmd2.Parameters.AddWithValue("@mun", mun.Text);
                                        cmd2.Parameters.AddWithValue("@bar", bar.Text);
                                        cmd2.Parameters.AddWithValue("@pur", pur.Text);
                                        cmd2.Parameters.AddWithValue("@bal", bal.Text);
                                        cmd2.Parameters.Add(new SqlParameter("@img", Extra.imgSelection()));

                                        if (nameExist(first.Text, mid.Text, last.Text, id.ToString()) == true)
                                        {
                                            Notification.Invalid("Customer Name Existed!");
                                        }
                                        else
                                        {
                                            cmd2.ExecuteNonQuery();
                                            Notification.Success("Customer Added!");
                                            cusId.Text = id.ToString();
                                            but.Text = "UPDATE";
                                            bal.Enabled = false;
                                        }    
                                    }
                                }
                            }
                        }
                        else
                        {
                            using (var cmdU = con.CreateCommand())
                            {
                                cmdU.CommandText = "UPDATE [zzz_Lending].[dbo].[CITB] SET [Firstname] = @first, " +
                                    "[Midname] = @mid, [Lastname] = @last, [Phone] = @mob, [FB] = @fb, " +
                                    "[Country] = @count, [Province] = @pro, [Municipality] = @mun, " +
                                    "[Barangay] = @bar, [Street/Purok] = @pur " +
                                    "WHERE [cusId] = @cusId";
                                cmdU.Parameters.AddWithValue("@cusId", cusId.Text);
                                cmdU.Parameters.AddWithValue("@first", first.Text);
                                cmdU.Parameters.AddWithValue("@mid", mid.Text);
                                cmdU.Parameters.AddWithValue("@last", last.Text);
                                cmdU.Parameters.AddWithValue("@mob", mob.Text);
                                cmdU.Parameters.AddWithValue("@fb", fb.Text);
                                cmdU.Parameters.AddWithValue("@count", count.Text);
                                cmdU.Parameters.AddWithValue("@pro", pro.Text);
                                cmdU.Parameters.AddWithValue("@mun", mun.Text);
                                cmdU.Parameters.AddWithValue("@bar", bar.Text);
                                cmdU.Parameters.AddWithValue("@pur", pur.Text);
                                cmdU.ExecuteNonQuery();
                                Notification.Success("Customer Updated!");
                            }
                        }
                       
                    }
                }
            }
            catch (ArgumentException)
            {
                Notification.Error("Please Upload your Avatar!");
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
        }

        public static void chkLogIn(TextBox usrTB, TextBox pass, TextBox pass2, 
            Label info, Panel pane, Form log)
        {
            try
            {
                if (Extra.isEmptyFields(pane) == true)
                {
                    Notification.Invalid("Missing Fields!");
                }
                else
                {
                    if (Extra.valPass(pass.Text) == false)
                    {
                        info.Visible = true;
                        info.ForeColor = Color.Red;
                        info.Text = "Invalid Format! e.g.(Abcde12)";
                        pass.Text = ""; pass2.Text = ""; pass.Focus();
                    }
                    else
                    {
                        info.Visible = false;
                        if (Extra.passMatch(pass, pass2) == false)
                        {
                            info.Visible = true;
                            info.ForeColor = Color.Red;
                            info.Text = "Password Don't Match!";
                            pass2.Text = ""; pass.Focus();
                        }
                        else
                        {
                            info.Visible = false;

                            using (var con = SQL.getConnection())
                            {
                                using (var cmd = con.CreateCommand())
                                {
                                    con.Open();
                                    cmd.CommandText = "SELECT * FROM [zzz_Lending].[dbo].[USRTB] " +
                                        "WHERE Username = @user AND Password = @pass";
                                    cmd.Parameters.AddWithValue("@user", usrTB.Text);
                                    cmd.Parameters.AddWithValue("@pass", Extra.GetMD5(pass.Text));

                                    using (var dr = cmd.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {
                                            Dashboard ma = new Dashboard();
                                            ma.Show(); Extra.clrCont(pane);
                                            log.Hide(); log.ShowInTaskbar = false;
                                        }
                                        else
                                        {
                                            Notification.Invalid("Incorrect Credentials!");
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
                Notification.Error(e.Message);
            }
        }

        public static void delCusInfo()
        {

        }
    }
}
