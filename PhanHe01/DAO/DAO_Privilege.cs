using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public class DAO_Privilege : DBConnect
    {
        private static DAO_Privilege _instance = null;

        public static DAO_Privilege Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_Privilege();
                }
                return _instance;
            }
        }

        public DataTable GetPrivilegeOnTable(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}' AND TYPE = 'TABLE'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetPrivilegeOnView(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}' AND TYPE = 'VIEW'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetPrivilegeOnColumnUpdateInsert(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '{username}'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }
        
        public void RevokeAllPrivilegesOnTable(String username, String table)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE ALL PRIVILEGES ON {table} FROM {username}";
            command.Connection = _conn;
            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void GrantPrivilegesOnTable(String username, String privileges, String table, bool grantable)
        {
            String grantableStr = "";
            if(grantable)
            {
                grantableStr = "WITH GRANT OPTION";
            }

            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {privileges} ON {table} TO {username} {grantableStr}";
            command.Connection = _conn;
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void GrantPrivilegeUpdateOnColumn(String username, String table, String column, bool grantable)
        {
            String grantableStr = "";
            if (grantable)
            {
                grantableStr = "WITH GRANT OPTION";
            }

            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT UPDATE({column}) ON {table} TO {username} {grantableStr}";
            command.Connection = _conn;
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void RevokePrivilegesSelectOnColumn(String username, String table, String column)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE SELECT ON {table + "_" + column + "_" + username + "_view"} FROM {username}";
            command.Connection = _conn;
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void GrantPrivilegeSelectOnColumn(String username, String table, String column, bool grantable)
        {
            String grantableStr = "N";
            if (grantable)
            {
                grantableStr = "Y";
            }
            OracleCommand command = new OracleCommand();
            command.CommandText = $"BEGIN GRANT_SELECT_ON_COLUMN('{table}', '{username}', '{column}', '{grantableStr}'); END;";
            command.Connection = _conn;
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();

        }
    }
}
