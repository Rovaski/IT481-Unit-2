using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_Unit_2
{
    static class dbManager
    {
        private static string dbConnectString = "";
        private static DateTime lastLogin;

        public static OleDbConnection InitDatabase(string ServerName, string TableName, string UserName, string Passcode)
        {
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnectString = String.Format(@"Provider=SQLOLEDB;Data Source = {0};Initial Catalog = {1}; User Id={2};Password={3};", ServerName, TableName, UserName, Passcode);
            dbConnection.ConnectionString = dbConnectString;
            dbConnection.Open();

            lastLogin = DateTime.Now;

            return dbConnection;
        }

        public static OleDbConnection LoadDatabase()
        {
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = dbConnectString;
            dbConnection.Open();

            return dbConnection;
        }

        public static void CloseDatabase()
        {
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = dbConnectString;
            dbConnection.Close();
        }

        public static DataTable LoadTable(string TableName)
        {
            OleDbCommand command = new OleDbCommand();

            command.Connection = dbManager.LoadDatabase();
            command.CommandText = string.Format("SELECT * FROM {0}", TableName);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            return dt;
        }

        public static DataTable TableCount(string TableName)
        {

            OleDbCommand command = new OleDbCommand();

            command.Connection = dbManager.LoadDatabase();
            command.CommandText = string.Format("SELECT * FROM {0}", TableName);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            return dt;
        }
    }
}
