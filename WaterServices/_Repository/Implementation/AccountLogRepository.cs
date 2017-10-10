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

        public DataTable getAccountLogs(string name, DateTime? from, DateTime? to)
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectAccountLog + " WHERE AccountLog.dDate >= @from AND AccountLog.dDate < @to";
                SQLiteParameter[] sqlParams = sqlParams = new SQLiteParameter[3];
                sqlParams[0] = new SQLiteParameter("@from", from);
                sqlParams[1] = new SQLiteParameter("@to", to);

                if (name != "") query += "INSTR(upper(Client.sFirstName), upper(@name)) > 0 OR INSTR(upper(Client.sLastName), upper(@name)) > 0";   

                sqlParams[2] = new SQLiteParameter("@name", name);

                query += " ORDER BY datetime(AccountLog.dDate) DESC ";
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
