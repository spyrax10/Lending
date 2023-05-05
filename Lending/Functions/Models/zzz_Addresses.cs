using Lending.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lending.Functions.Models
{
    public class zzz_Addresses
    {
        public int ID { get; set; } = 0;
        public string countId { get; set; } = null;

        public string Country { get; set; } = null;
        public string Province { get; set; } = null;
        public string Municipality { get; set; } = null;
        public string Barangay { get; set; } = null;

        public static List<zzz_Addresses> _placesList = null;

        public static List<zzz_Addresses> GetPlaces()
        {
            _placesList = new List<zzz_Addresses>();

            try
            {
                using (var con = SQL.getConnection())
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM [zzz_Lending].[dbo].[zzz_Addresses]";

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                zzz_Addresses place = new zzz_Addresses();
                                place.ID = Int32.Parse(dr["ID"].ToString());
                                place.Country = dr["Country"].ToString();
                                place.Province = dr["Province"].ToString();
                                place.Municipality = dr["Municipality"].ToString();
                                place.Barangay = dr["Barangay"].ToString();
                                _placesList.Add(place);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Extra.createLogFile("[Error][zzz_Addresses.GetPlaces]" + e.Message);
                if (e is SqlException)
                {
                    Notification.Error("Can't Connect To Server! Please Try Again!");
                }
                else
                {
                    Notification.Error("Code Error! Please contact the Developer!");
                }

                _placesList = null;
            }

            return _placesList;
        }
    }
}
