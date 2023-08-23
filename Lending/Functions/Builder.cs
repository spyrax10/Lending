using Lending.Functions;
using System;

namespace Lending.Class
{
    public class Builder
    {
        public static void CreateAppDatabase()
        {
            try
            {
                using (var con = SQL.getConnection())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'zzz_Lending') " +
                                    "BEGIN CREATE DATABASE[zzz_Lending] END ";
                        cmd.ExecuteNonQuery();

                        using (var cmd2 = con.CreateCommand())
                        {
                            cmd2.CommandText =

                            #region Company
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'Company') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[Company]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[Date] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Parent_Id] INT DEFAULT 0, " +
                            "[Owner_Id] INT DEFAULT 0, " +
                            "[Code] [varchar](45) DEFAULT NULL, " +
                            "[Name] [varchar](100) DEFAULT NULL, " +
                            "[TIN] [varchar](100) DEFAULT NULL, " +
                            "[Enable_logs] INT DEFAULT 0, " +
                            "[Display_per_page] INT DEFAULT 0, " +
                            "[Last_Update] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Inactive] INT DEFAULT 0, " +
                            "[Hash_Id] [varchar](100) DEFAULT NULL " +
                            "); END " +
                            #endregion

                            #region Addresses
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'Addresses') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[Addresses]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[Date] [varchar](100) DEFAULT '0000-00-00', " +
                            "[User_Id] INT DEFAULT 0, " +
                            "[Branch_Id] INT DEFAULT 0, " +
                            "[Type] INT DEFAULT 0, " +
                            "[Country] VARCHAR(100) NOT NULL, " +
                            "[Province]	VARCHAR(100) NOT NULL, " +
                            "[Municipality] VARCHAR(100) NOT NULL, " +
                            "[Barangay] VARCHAR(100) NOT NULL, " +
                            "[Street/Purok] VARCHAR(100) NOT NULL, " +
                            "[ZipCode] VARCHAR(45) NOT NULL, " +
                            "[Last_Update] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Inactive] INT DEFAULT 0, " +
                            "[Hash_Id] [varchar](100) DEFAULT NULL " +
                            "); END " +
                            #endregion

                            #region Contacts
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'Contacts') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[Contacts]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[Date] [varchar](100) DEFAULT '0000-00-00', " +
                            "[User_Id] INT DEFAULT 0, " +
                            "[Branch_Id] INT DEFAULT 0, " +
                            "[Type] INT DEFAULT 0, " +
                            "[Email] VARCHAR(45) DEFAULT NULL, " +
                            "[FB] VARCHAR(45) DEFAULT NULL, " +
                            "[Mobile] VARCHAR(45) DEFAULT NULL, " +
                            "[Telephone] [varchar](45) DEFAULT NULL, " +
                            "[Secondary] INT DEFAULT 0, " +
                            "[Email_Verified] INT DEFAULT 0, " +
                            "[Mobile_Verified] INT DEFAULT 0, " +
                            "[2FA_ON] INT DEFAULT 0, " +
                            "[Last_Update] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Inactive] INT DEFAULT 0, " +
                            "[Hash_Id] [varchar](100) DEFAULT NULL " +
                            "); END " +
                            #endregion

                            #region User
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'User') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[User]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[Date] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Branch_Id] INT DEFAULT 0, " +
                            "[Role_Id] INT DEFAULT 0, " +
                            "[Username] [varchar](45) DEFAULT NULL, " +
                            "[Password] [varchar](100) DEFAULT NULL, " +
                            "[FirstName] [varchar](45) DEFAULT NULL, " +
                            "[MiddleName] [varchar](45) DEFAULT NULL, " +
                            "[LastName] [varchar](45) DEFAULT NULL, " +
                            "[Date_Hired] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Photo] [image] DEFAULT NULL, " +
                            "[Last_Update] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Inactive] INT DEFAULT 0, " +
                            "[Hash_Id] [varchar](100) DEFAULT NULL " +
                            "); END " +
                            #endregion

                            #region User_Branch
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'User_Branch') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[User_Branch]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[User_Id] INT DEFAULT 0, " +
                            "[Branch_Id] INT DEFAULT 0, " +
                            "[Inactive] INT DEFAULT 0 " +
                            "); END " +
                            #endregion

                            #region User_Type
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'User_Type') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[User_Type]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[Name] VARCHAR(50) DEFAULT NULL, " +
                            "[Inactive] INT DEFAULT 0 " +
                            "); END " +
                            #endregion

                            #region User_Session
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'User_Session') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[User_Session] " +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[User_Id] INT DEFAULT 0, " +
                            "[Branch_Id] INT DEFAULT 0, " +
                            "[Date] VARCHAR(50) DEFAULT '0000-00-00', " +
                            "[Time] VARCHAR(50) DEFAULT '00:00:00', " +
                            "[IP] VARCHAR(100) DEFAULT NULL, " +
                            "[PC] VARCHAR(100) DEFAULT NULL, " +
                            "[Action_Id] INT DEFAULT 0, " +
                            "[Hash_Id] [varchar](100) DEFAULT NULL " +
                            "); END " +
                            #endregion

                            #region Customer
                            "IF NOT EXISTS (SELECT A.TABLE_NAME FROM zzz_Lending.INFORMATION_SCHEMA.TABLES A " +
                            "WHERE A.TABLE_NAME = 'Customer') " +
                            "BEGIN " +
                            "CREATE TABLE [zzz_Lending].[dbo].[Customer]" +
                            "( " +
                            "[Id] INT IDENTITY(1,1) PRIMARY KEY, " +
                            "[Date] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Branch_Id] INT DEFAULT 0, " +
                            "[Role_Id] INT DEFAULT 0, " +
                            "[FirstName] [varchar](45) DEFAULT NULL, " +
                            "[MiddleName] [varchar](45) DEFAULT NULL, " +
                            "[LastName] [varchar](45) DEFAULT NULL, " +
                            "[Balance] [numeric](19, 2) DEFAULT 0, " +
                            "[Photo] [image] DEFAULT NULL, " +
                            "[Last_Update] [varchar](100) DEFAULT '0000-00-00', " +
                            "[Inactive] INT DEFAULT 0, " +
                            "[Hash_Id] [varchar](100) DEFAULT NULL " +
                            "); END " +
                            #endregion

                            #region Adding Default User_Type
                            "IF NOT EXISTS (SELECT Name FROM [zzz_Lending].[dbo].[User_Type] A " +
                            "WHERE  Name = 'Company') " +
                            "BEGIN " +
                            "INSERT INTO [zzz_Lending].[dbo].[User_Type] VALUES ('Company', 0) " +
                            "END " +

                            "IF NOT EXISTS (SELECT Name FROM [zzz_Lending].[dbo].[User_Type] A " +
                            "WHERE  Name = 'Customer') " +
                            "BEGIN " +
                            "INSERT INTO [zzz_Lending].[dbo].[User_Type] VALUES ('Customer', 0) " +
                            "END " +

                            "IF NOT EXISTS (SELECT Name FROM [zzz_Lending].[dbo].[User_Type] A " +
                            "WHERE  Name = 'User') " +
                            "BEGIN " +
                            "INSERT INTO [zzz_Lending].[dbo].[User_Type] VALUES ('User', 0) " +
                            "END ";
                            #endregion

                            cmd2.ExecuteNonQuery();

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }
        }
    }
}
