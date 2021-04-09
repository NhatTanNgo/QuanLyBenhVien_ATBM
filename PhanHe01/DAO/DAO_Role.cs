using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public class DAO_Role : DBConnect
    {
        private static DAO_Role _instance = null;
        public static DAO_Role Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_Role();
                }
                return _instance;
            }
        }

        public DataTable GetAllRoles()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_ROLES";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
