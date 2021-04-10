using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;

namespace DAO
{
    public class DAO_Table :DBConnect
    {
        private static DAO_Table _instance = null;
        public static DAO_Table Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_Table();
                }
                return _instance;
            }
        }

        public DataTable GetAllTables()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT DISTINCT OWNER, OBJECT_NAME " +
                                  $"FROM ALL_OBJECTS " +
                                  $"WHERE OBJECT_TYPE = 'TABLE' AND OWNER = '{DBAUsername.ToUpper()}'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetAllColumnFromTable(String tableName)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT column_name " +
                                  $"FROM user_tab_cols " +
                                  $"WHERE table_name = '{tableName}'" ;
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetAllTableGranted(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
