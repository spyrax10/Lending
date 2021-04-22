using System;
using System.Collections.Generic;
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
                                        "WHERE A.TABLE_NAME = 'usrTB') " +
                                        "BEGIN " +
                                        "CREATE TABLE [lendDB].[dbo].[usrTB]" +
                                        "( " +
                                        "[ID] INT NOT NULL, " +
                                        "[Username] VARCHAR(20) NOT NULL, " +
                                        "[Password] VARCHAR(100) NOT NULL, " +
                                        "[Email]	VARCHAR(50) NULL, " +
                                        "[EStat] VARCHAR(10) NULL, " +
                                        "[DateJoin]	VARCHAR(50) NOT NULL, " +
                                        "[Status] VARCHAR(50) NOT NULL); END " +
                                        
                                        "IF NOT EXISTS (SELECT A.TABLE_NAME FROM lendDB.INFORMATION_SCHEMA.TABLES A " +
                                        "WHERE A.TABLE_NAME = 'logTB') " +
                                        "BEGIN " +
                                        "CREATE TABLE [lendDB].[dbo].[logTB]" +
                                        "(" +
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

                                        "IF NOT EXISTS (SELECT A.ID FROM [lendDB].[dbo].[usrTB] A " +
                                        "WHERE A.ID = 0) " +
                                        "BEGIN " +
                                        "INSERT INTO lendDB.dbo.usrTB VALUES (" +
                                        "0, " +
                                        "'admin', " +
                                        "'" + misc.GetMD5("123450") + "', " +
                                        "'', " +
                                        "'PENDING', " +
                                        "'" + DateTime.Now.ToShortDateString() + "', " +
                                        "'ADMIN' ) END ";
                            cmd2.ExecuteNonQuery();
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
