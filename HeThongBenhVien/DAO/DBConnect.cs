using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public class DBConnect
    {
        protected static OracleConnection _conn = null;
        //protected static OracleConnection _conn = new OracleConnection("Data Source=localhost:1521/xepdb1;Persist Security Info=True;User ID = OT; Password= minhlamv18");
        protected static String _username = null;
        protected static String _dbSchema = "OT";

        //Data Source = IP:Port/Database name (SID)
        //UserID = username
        //Password = password
        public static void InitConnection(String username, String password, String dbName)
        {
            //String connectionString = $"Data Source=localhost:1521/{dbName};Persist Security Info=True;User ID = {username}; Password={password}";
            String connectionString = $"Data Source=localhost:1521/{dbName};Persist Security Info=True;User ID = {username}; Password= {password}";

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(connectionString);
                _conn = connection;
                _conn.Open();
                _conn.Close();
                _username = username;
            }
            catch (OracleException ex)
            {
                _conn = null;
                throw new Exception(ex.Message);
            }
        }

        public String GetUsername() { return _username; }
    }
}
