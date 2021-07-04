using Oracle.ManagedDataAccess.Client;
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
            command.CommandText = $"Select Role, Role_ID " +
                                  $"From user_ROLE_PRIVS US join DBA_ROLES DR ON DR.ROLE = US.GRANTED_ROLE " +
                                  $"WHERE DR.ROLE <> 'CONNECT' AND DR.ROLE <> 'RESOURCE' AND DR.ROLE <> 'DBA'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void GrantRoleToUser(String role, String username, bool? grantOpt)
        {
            //OracleCommand command = new OracleCommand();
            //command.CommandText = $"GRANT {role} TO {username}";
            //command.Connection = _conn;

            OracleCommand command = new OracleCommand("GRANT_ROLE", _conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("USERNAME", OracleDbType.Varchar2);
            param1.Value = username;
            OracleParameter param2 = new OracleParameter("GRANT_ROLE", OracleDbType.Varchar2);
            param2.Value = role;
            OracleParameter param3 = new OracleParameter("GRANT_OPTION", OracleDbType.Int32);
            param3.Value = (bool)grantOpt ? 1 : 0;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch(OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
           
        }

        public void RevokeRoleFromUser(String role, String username)
        {
            OracleCommand command = new OracleCommand("REVOKE_ROLE", _conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("R_USERNAME", OracleDbType.Varchar2);
            param1.Value = username;
            OracleParameter param2 = new OracleParameter("R_ROLE", OracleDbType.Varchar2);
            param2.Value = role;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw ex;
            }
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

        public DataTable GetRolesOfUser(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{username}'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            try
            {
                adapter.Fill(dataTable);
            }
            catch(OracleException ex)
            {
                throw new Exception(ex.Message);
            }


            return dataTable;
        }
    }
}
