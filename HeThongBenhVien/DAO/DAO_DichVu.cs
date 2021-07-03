using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_DichVu : DBConnect
    {
        private static DAO_DichVu _instance = null;
        public static DAO_DichVu Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_DichVu();
                }
                return _instance;
            }
        }

        public DataTable GetServiceInfor()
        {
            try
            {
                _conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = $"select * from {_dbSchema}.dichvu";
                command.Connection = _conn;

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
                _conn.Close();
                return dataTable;
            }
            catch(OracleException e)
            {
                _conn.Close();
                throw e;
            }
        }
    }
}
