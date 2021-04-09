using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public class DAO_User: DBConnect
    {
        private static DAO_User _instance = null;
        public static DAO_User Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_User();
                }
                return _instance;
            }
        }

        public DataTable GetAllUsers()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM all_users ORDER BY CREATED DESC";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

    }
}
