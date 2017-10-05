using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using WaterServices.Properties;

namespace WaterServices._Repository
{
    public class AccountLogRepository : IAccountLogRepository
    {
        private DatabaseConnection conn;

        public AccountLogRepository()
        {
            conn = new DatabaseConnection();
            
        }

        public DataTable getAccountLogs(string name)
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectAccountLog;
                SQLiteParameter[] sqlParams = null;
                if (name != "")
                {
                    sqlParams = new SQLiteParameter[1];
                    query += " WHERE Client.sFirstName || Client.sLastName LIKE @name";                    
                    sqlParams[0] = new SQLiteParameter("@name", name);                   
                }

                ret = conn.executeSelectQuery(query, sqlParams);
            }
            catch (Exception e)
            {
                ret = null;
                Console.WriteLine(e.Message);
            }
            return ret;
        }        
    }
}
