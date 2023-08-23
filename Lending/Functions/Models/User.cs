using System.ComponentModel.DataAnnotations;
using System;

namespace Lending.Functions.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int Branch_Id { get; set; } = 0;
        public int Role_Id { get; set; } = 0;

        public string Username { get; set; } = null;
        public string Password { get; set; } = null;

        public string FirstName { get; set; } = null;
        public string MiddleName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Date_Hired { get; set; } = "0000-00-00";
        public byte[] Photo { get; set; } = null;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;

        public int NewUser(Contacts contacts, int comp_Id = 0, bool isCompany = true)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO [zzz_Lending].[dbo].[User](
                            Date, Branch_Id, Username, Password,
                            FirstName, MiddleName, LastName) 
                        VALUES(@date, @branch_id, @username, @password, @firstName, @middleName, @lastName)
                        SELECT SCOPE_IDENTITY() AS last_inserted_id;";

                        cmd.Parameters.AddWithValue("date", Date);
                        cmd.Parameters.AddWithValue("branch_id", comp_Id);
                        cmd.Parameters.AddWithValue("username", Username);
                        cmd.Parameters.AddWithValue("password", Password);
                        cmd.Parameters.AddWithValue("firstName", FirstName);
                        cmd.Parameters.AddWithValue("middleName", MiddleName);
                        cmd.Parameters.AddWithValue("lastName", LastName);

                        Id = Convert.ToInt32(cmd.ExecuteScalar());

                        if (Id > 0)
                        {
                            contacts.NewContact(this, comp_Id);
                        }
                        else
                        {
                            SQL.deleteLastInsertedId(comp_Id, "Company");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(Username + " || " + e.Message);
                SQL.deleteLastInsertedId(comp_Id, "Company");
            }

            return Id;
        }
    }
}
