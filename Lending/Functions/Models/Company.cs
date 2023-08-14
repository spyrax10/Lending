using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int Parent_Id { get; set; } = 0;
        public int Owner_Id { get; set; } = 0;
        public string Code { get; set; } = null;
        public string Name { get; set; } = null;
        public string TIN { get; set; } = null;
        public int Enable_logs { get; set; } = 0;
        public int Display_per_page { get; set; } = 0;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;

        public bool CompanyExists()
        {
            bool exists = false; string qry = "";

            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        qry = "SELECT A.Id FROM [zzz_Lending].[dbo].[Company] A " +
                          "WHERE ";

                        if (Code != null)
                        {
                            qry += " A.Code = @code";
                        }

                        if (Name != null)
                        {
                            qry += " A.Name = @comp_name";
                        }

                        if (Id > 0)
                        {
                            qry += " AND A.Id <> @comp_ID";
                        }

                        cmd.CommandText = qry;

                        if (Code != null)
                        {
                            cmd.Parameters.AddWithValue("@code", Code);
                        }

                        if (Name != null)
                        {
                            cmd.Parameters.AddWithValue("@comp_name", Name);
                        }

                        if (Id > 0)
                        {
                            cmd.Parameters.AddWithValue("@comp_ID", Id);
                        }

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                exists = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }

            return exists;
        }

        public int CreateNewCompany(Company company, User user, Contacts contacts)
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO [zzz_Lending].[dbo].[Company](Date, Code, Name) 
                            VALUES(@date, @code, @name)
                            SELECT SCOPE_IDENTITY() AS last_inserted_id;";

                        cmd.Parameters.AddWithValue("@date", Date);
                        cmd.Parameters.AddWithValue("@code", Code);
                        cmd.Parameters.AddWithValue ("@name", Name);

                        Id = Convert.ToInt32(cmd.ExecuteScalar());

                        if (Id > 0)
                        {
                            user.NewUser(company, contacts);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Id = 0;
                Notification.Error(e.Message);
            }

            return Id;
        }
    }
}
