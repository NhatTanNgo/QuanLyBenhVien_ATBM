using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_User
    {
        private static BUS_User _instance = null;
        public static BUS_User Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BUS_User();
                }
                return _instance;
            }
        }

        public List<DTO_User> GetAllUsers()
        {
            //Get all data from DAO Layer
            List<DTO_User> result = new List<DTO_User>();
            DataTable data = DAO_User.Instance.GetAllUsers();

            foreach (DataRow row in data.Rows)
            {
                DTO_User tmpObject = new DTO_User();

                tmpObject.Username = row["USERNAME"].ToString();
                tmpObject.Username_ID = row["USER_ID"].ToString();
                tmpObject.Created = row["CREATED"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }

        public bool CheckUser(String username)
        {
            DataTable data = DAO_User.Instance.GetAllUsers();
            foreach(DataRow row in data.Rows)
            {
                DTO_User tmpObject = new DTO_User();
                tmpObject.Username = row["USERNAME"].ToString();

                if(tmpObject.Username.Equals(username))
                {
                    return true;
                }
            }
            return false;
            
        }

        public void CreateUser(String username, String password)
        {
            try
            {
                DAO_User.Instance.CreateUser(username, password);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteUser(String username, bool cascade)
        {
            try
            {
                DAO_User.Instance.DeleteUser(username, cascade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(String username, bool isLock, string password)
        {
            try
            {
                DAO_User.Instance.UpdateUser(username, isLock, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
