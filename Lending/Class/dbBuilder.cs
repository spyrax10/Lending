using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lending.Class
{
    public class dbBuilder
    {
        public static void createDB()
        {
            try
            {
                string sql = ConfigurationManager.AppSettings["SQL"].ToString();

                using (var con = misc.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'lendDB') " +
                                    "BEGIN CREATE DATABASE[lendDB] END ";
                        cmd.ExecuteNonQuery();

                        using (var cmd2 = con.CreateCommand())
                        {
                            cmd2.CommandText = "IF NOT EXISTS (SELECT A.TABLE_NAME FROM lendDB.INFORMATION_SCHEMA.TABLES A " +
                                        "WHERE A.TABLE_NAME = 'USRTB') " +
                                        "BEGIN " +
                                        "CREATE TABLE [lendDB].[dbo].[USRTB]" +
                                        "( " +
                                        "[ID] INT NOT NULL, " +
                                        "[Username] VARCHAR(20) NOT NULL, " +
                                        "[Password] VARCHAR(100) NOT NULL, " +
                                        "[Email]	VARCHAR(50) NULL, " +
                                        "[EStat] VARCHAR(10) NULL, " +
                                        "[DateJoin]	VARCHAR(50) NOT NULL, " +
                                        "[Status] VARCHAR(50) NOT NULL); END " +
                                        
                                        "IF NOT EXISTS (SELECT A.TABLE_NAME FROM lendDB.INFORMATION_SCHEMA.TABLES A " +
                                        "WHERE A.TABLE_NAME = 'LOGTB') " +
                                        "BEGIN " +
                                        "CREATE TABLE [lendDB].[dbo].[LOGTB] " +
                                        "( " +
                                        "[ID] INT NOT NULL, " +
                                        "[Date] VARCHAR(50) NOT NULL," +
                                        "[Time] VARCHAR(50) NOT NULL, " +
                                        "[IP] VARCHAR(100) NOT NULL, " +
                                        "[PC] VARCHAR(100) NOT NULL, " +
                                        "[Action] VARCHAR(100) NOT NULL, " +
                                        "[Table] VARCHAR(100) NOT NULL, " +
                                        "[TransID] INT NOT NULL, " +
                                        "[OrigValue] VARCHAR(100) NOT NULL," +
                                        "[UpdValue] VARCHAR(100) NOT NULL); END " +
                                        
                                        "IF NOT EXISTS (SELECT A.TABLE_NAME FROM lendDB.INFORMATION_SCHEMA.TABLES A " +
                                        "WHERE A.TABLE_NAME = 'CITB') " +
                                        "BEGIN " +
                                        "CREATE TABLE [lendDB].[dbo].[CITB] " +
                                        "( " +
                                        "[cusId] INT NOT NULL, " +
                                        "[Firstname] VARCHAR(100) NOT NULL, " +
                                        "[Midname]	VARCHAR(100) NULL, " +
                                        "[Lastname]	VARCHAR(100) NOT NULL, " +
                                        "[Phone]	VARCHAR(50)  NOT NULL, " +
                                        "[FB]		VARCHAR(100) NULL, " +
                                        "[Country]	VARCHAR(100) NOT NULL, " +
                                        "[Province]	VARCHAR(100) NOT NULL, " +
                                        "[Municipality] VARCHAR(100) NOT NULL, " +
                                        "[Barangay] VARCHAR(100) NOT NULL, " +
                                        "[Street/Purok] VARCHAR(100) NOT NULL, " +
                                        "[Balance]	VARCHAR(8000) NOT NULL, " +
                                        "[Photo]	IMAGE NOT NULL ); END " +
                                               
                                        "IF NOT EXISTS (SELECT A.ID FROM [lendDB].[dbo].[USRTB] A " +
                                        "WHERE A.ID = 0) " +
                                        "BEGIN " +
                                        "INSERT INTO [lendDB].[dbo].[USRTB] VALUES (" +
                                        "0, " +
                                        "'admin', " +
                                        "'" + misc.GetMD5("Abcde12") + "', " +
                                        "'', " +
                                        "'PENDING', " +
                                        "'" + DateTime.Now.ToShortDateString() + "', " +
                                        "'ADMIN' ) END ";
                            cmd2.ExecuteNonQuery();
                            misc.addCountTB(sql);
                            misc.createFold();
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
