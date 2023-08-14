using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class Addresses
    {
        [Key]
        public int Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int User_Id { get; set; } = 0;
        public int Branch_Id { get; set; } = 0;
        public int Type { get; set; } = 0;

        public string Country { get; set; } = null;
        public string Province { get; set; } = null;
        public string Municipality { get; set; } = null;
        public string Barangay { get; set; } = null;
        public string Street { get; set; } = null;
        public string ZipCode { get; set; } = null;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;

        public int NewAddress(Company company, User user, Contacts contacts)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO [zzz_Lending].[dbo].[Addresses](
                            Date, User_Id, Branch_Id, Country, Province, Municipality, Barangay, [Street/Purok], ZipCode, 
                            LastUpdate) 
                        VALUES(@date, @user_id, @country, @province, @municipality, @barangay, @purok, @zip 
                            @lastUpdate)
                        SELECT SCOPE_IDENTITY() AS last_inserted_id;";

                        cmd.Parameters.AddWithValue("date", Date);
                        
                        cmd.Parameters.AddWithValue("branch_id", company.Id);
                        cmd.Parameters.AddWithValue("user_id", user.Id);
                        cmd.Parameters.AddWithValue("lastUpdate", Last_Update);

                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);

                SQL.deleteLastInsertedId(company.Id, "Company");
                SQL.deleteLastInsertedId(user.Id, "User");
            }

            return Id;
        }
    }
}
