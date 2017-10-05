using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace WaterServices
{
    public class DatabaseConnection
    {
        private SQLiteConnection conn;
        private SQLiteDataAdapter adapter;
        private string connString = ConfigurationManager.
            ConnectionStrings["WaterServices.Properties.Settings.WaterServicesConnectionString"].ConnectionString;

        public DatabaseConnection()
        {
            adapter = new SQLiteDataAdapter();
            conn = new SQLiteConnection(connString);
        }

        private SQLiteConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || 
                conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public DataTable executeSelectQuery(String _query, SQLiteParameter[] param)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                if (!isNullOrEmpty(param)) cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();                
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SQLiteException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " 
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                
            }
            return dataTable;
        }

        private bool isNullOrEmpty(Array array)
        {
            return (array == null || array.Length == 0);
        }
    }
}
