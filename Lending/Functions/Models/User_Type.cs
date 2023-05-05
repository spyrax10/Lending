using Lending.Class;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Lending.Functions.Models
{
    public class User_Type
    {
        [Key]
        public int Id { get; set; } = 0;

        public string Name { get; set; } = null;
        public int Inactive { get; set; } = 0;

        public static List<User_Type> _userTypes = null;

        public static List<User_Type> GetUserType()
        {
            _userTypes = new List<User_Type>();

            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM [zzz_Lending].[dbo].[User_Type]";

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                User_Type type = new User_Type();
                                type.Id = Int32.Parse(dr["Id"].ToString());
                                type.Name = dr["Name"].ToString();
                                type.Inactive = Int32.Parse(dr["Inactive"].ToString());
                                _userTypes.Add(type);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Extra.createLogFile("[Error][UserTypes.GetUserType]" + e.Message);
                if (e is SqlException)
                {
                    Notification.Error("Can't Connect To Server! Please Try Again!");
                }
                else
                {
                    Notification.Error("Code Error! Please contact the Developer!");
                }

                _userTypes = null;
            }

            return _userTypes;
        }
    }
}
