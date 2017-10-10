using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using WaterServices.Properties;

namespace WaterServices._Repository
{    
    public class ProductRepository : IProductRepository
    {
        private DatabaseConnection conn;

        public ProductRepository()
        {
            conn = new DatabaseConnection();            
        }

        public System.Data.DataTable getProducts(string code)
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectProduct;
                SQLiteParameter[] sqlParams = null;
                if (code != "")
                {
                    sqlParams = new SQLiteParameter[1];
                    query += " WHERE Product.sCode = @code";
                    sqlParams[0] = new SQLiteParameter("@code", code);
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

        public System.Data.DataTable getProductContainers()
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectProductContainer;
                ret = conn.executeSelectQuery(query, null);
            }
            catch (Exception e)
            {
                ret = null;
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public System.Data.DataTable getProductTypes()
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectProductType;
                ret = conn.executeSelectQuery(query, null);
            }
            catch (Exception e)
            {
                ret = null;
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public System.Data.DataTable getProductVolumes()
        {
            DataTable ret = null;
            try
            {
                string query = Resources.selectProductVolume;
                ret = conn.executeSelectQuery(query, null);
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
