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

        public void GrantRoleToUser(String role, String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {role} TO {username}";
            command.Connection = _conn;

            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void CreateRole(String rolename, String password)
        {
            bool hasPassword = true;
            if(password.Length==0)
            {
                hasPassword = false;
            }

            OracleCommand command = new OracleCommand();
            if(hasPassword)
            {
                command.CommandText = $"CREATE ROLE {rolename} IDENTIFIED BY {password}";
            }
            else
            {
                command.CommandText = $"CREATE ROLE {rolename} NOT IDENTIFIED";
            }
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

        public void DeleteRole(String rolename)
        {
           
            OracleCommand command = new OracleCommand();
            command.CommandText = $"DROP ROLE {rolename}";
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
    }
}
