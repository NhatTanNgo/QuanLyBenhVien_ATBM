using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_Role
    {
        private static BUS_Role _instance = null;
        public static BUS_Role Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Role();
                }
                return _instance;
            }
        }

        public List<DTO_Role> GetAllRoles()
        {
            //Get all data from DAO Layer
            List<DTO_Role> result = new List<DTO_Role>();
            DataTable data = DAO_Role.Instance.GetAllRoles();

            foreach (DataRow row in data.Rows)
            {
                DTO_Role tmpObject = new DTO_Role();

                tmpObject.RoleName = row["ROLE"].ToString();
                tmpObject.Role_ID = row["ROLE_ID"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }

        public bool CheckRole(String roleName)
        {
            DataTable data = DAO_Role.Instance.GetAllRoles();
            foreach (DataRow row in data.Rows)
            {
                DTO_Role tmpObject = new DTO_Role();
                tmpObject.RoleName = row["ROLE"].ToString();

                if (tmpObject.RoleName.Equals(roleName))
                {
                    return true;
                }
            }
            return false;

        }

        public void GrantRoleToUser(String role, String username, bool? grantOpt)
        {
            try
            {
                DAO_Role.Instance.GrantRoleToUser(role, username, grantOpt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RevokeRoleToUser(String role, String username)
        {
            try
            {
                DAO_Role.Instance.RevokeRoleFromUser(role, username);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CreateRole(String rolename, String password)
        {
            try
            {
                DAO_Role.Instance.CreateRole(rolename, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRole(String rolename)
        {
            try
            {
                DAO_Role.Instance.DeleteRole(rolename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DTO_Role> GetRolesOfUser(String username)
        {

            List<DTO_Role> result = new List<DTO_Role>();
            DataTable data;
            try
            {
                data = DAO_Role.Instance.GetRolesOfUser(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in data.Rows)
            {
                DTO_Role tmpObject = new DTO_Role();

                tmpObject.RoleName = row["GRANTED_ROLE"].ToString();
                tmpObject.Admin_Option = row["ADMIN_OPTION"].ToString();

                result.Add(tmpObject);
            }

            return result;
           
        }

    }
}
