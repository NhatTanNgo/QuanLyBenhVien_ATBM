using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public class DAO_Thuoc : DBConnect
    {
        private static DAO_Thuoc _instance = null;

        public static DAO_Thuoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Thuoc();
                }
                return _instance;
            }
        }
        public DataTable GetDrugs()
        {
            try
            {
                _conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = $"select * from {_dbSchema}.thuoc";
                command.Connection = _conn;

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
                _conn.Close();
                return dataTable;
            }
            catch (OracleException e)
            {
                _conn.Close();
                throw e;
            }
        }

    }
    
}
