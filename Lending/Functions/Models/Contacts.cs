using Lending.Forms;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int User_Id { get; set; } = 0;
        public int Branch_Id { get; set; } = 0;
        public int Type { get; set; } = 0;

        public string Email { get; set; } = null;
        public string FB { get; set; } = null;
        public string Mobile { get; set; } = null;
        public string Telephone { get; set; } = null;
        public int Secondary { get; set; } = 0;
        public int Email_Verified { get; set; } = 0;
        public int Mobile_Verified { get; set; } = 0;
        public int Authen_ON { get; set; } = 0; 

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;

        public bool ContactExists()
        {
            bool exists = false;

            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        string qry = "SELECT A.Id FROM [zzz_Lending].[dbo].[Contacts] A " +
                          "WHERE ";

                        if (Email != null)
                        {
                            qry += "A.Email = @email";
                        }
                        else if (Mobile != null)
                        {
                            qry += "A.Mobile = @mobile";
                        }

                        cmd.CommandText = qry;

                        cmd.Parameters.AddWithValue("email", Email);
                        cmd.Parameters.AddWithValue ("mobile", Mobile);
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }

            return exists;
        }

        public int NewContact(Company company, User user)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO [zzz_Lending].[dbo].[Contacts](
                            Date, User_Id, Branch_Id, Type, Email, Mobile) 
                        VALUES(@date, @user_id, @branch_id, @type, 
                            @email, @mobile)
                        SELECT SCOPE_IDENTITY() AS last_inserted_id;";

                        cmd.Parameters.AddWithValue("date", Date);
                        cmd.Parameters.AddWithValue("branch_id", company.Id);
                        cmd.Parameters.AddWithValue("user_id", user.Id);
                        cmd.Parameters.AddWithValue("type", Type);
                        cmd.Parameters.AddWithValue("email", Email);
                        cmd.Parameters.AddWithValue("mobile", Mobile);

                        Id = Convert.ToInt32(cmd.ExecuteScalar());

                        if (Id > 0)
                        {
                            Notification.Success("Company Created...");
                            Dashboard home = new Dashboard();
                            home.ShowDialog();
                            
                        }
                        else
                        {
                            SQL.deleteLastInsertedId(company.Id, "Company");
                            SQL.deleteLastInsertedId(user.Id, "User");
                        }

                    }
                }
            }
            catch(Exception e)
            {
                Notification.Error(e.Message);

                SQL.deleteLastInsertedId(company.Id, "Company");
                SQL.deleteLastInsertedId(user.Id, "User");
            }

            return Id;
        }
    }
}
