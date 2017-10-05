using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using WaterServices.Properties;

namespace WaterServices._Repository
{
    public class ClientRepository : IClientRepository
    {
        private DatabaseConnection conn;

        public ClientRepository()
        {
            conn = new DatabaseConnection();
            
        }

        public DataTable getClients()
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectClient;
                ret = conn.executeSelectQuery(query, null);
            }
            catch (Exception e)
            {
                ret = null;
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(ret);

            return ret;
        }

        public DataTable getClientById(string id)
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectClient 
                    + "WHERE "
                        + "Client.id = @id";
                SQLiteParameter[] sqlParams = new SQLiteParameter[1];
                sqlParams[0] = new SQLiteParameter("@id", id);
                ret = conn.executeSelectQuery(query, sqlParams);
            }
            catch (Exception e)
            {
                ret = null;
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public DataTable getClientAndLocationById(string id)
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectClientLocation
                    + "WHERE "
                        + "Client.id = @id";
                SQLiteParameter[] sqlParams = new SQLiteParameter[1];
                sqlParams[0] = new SQLiteParameter("@id", id);
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
