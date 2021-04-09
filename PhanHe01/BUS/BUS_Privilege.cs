using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_Privilege
    {
        private static BUS_Privilege _instance = null;
        public static BUS_Privilege Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BUS_Privilege();
                }
                return _instance;
            }
        }

        public List<DTO_PrivilegeOnTable> GetPrivilegesOnTable(String username)
        {
            //Get all data from DAO Layer
            List<DTO_PrivilegeOnTable> result = new List<DTO_PrivilegeOnTable>();
            DataTable data = DAO_Privilege.Instance.GetPrivilegeOnTable(username);

            foreach (DataRow row in data.Rows)
            {
                bool flag = false;
                DTO_PrivilegeOnTable tmpObject = new DTO_PrivilegeOnTable();

                tmpObject.TableName = row["TABLE_NAME"].ToString();
                if(result.Count > 0 && result[result.Count - 1].TableName.Equals(tmpObject.TableName)) {
                    tmpObject = result[result.Count - 1];
                    flag = true;
                }

                String privilege = row["PRIVILEGE"].ToString();

                if(privilege.Equals("SELECT"))
                {
                    tmpObject.IsSelect = true;
                }
                else if (privilege.Equals("INSERT"))
                {
                    tmpObject.IsInsert = true;
                }
                else if (privilege.Equals("UPDATE"))
                {
                    tmpObject.IsUpdate = true;
                }
                else
                {
                    tmpObject.IsDelete = true;
                }

                if(!flag)
                {
                    result.Add(tmpObject);
                }

            }

            return result;
        }

    }
}
