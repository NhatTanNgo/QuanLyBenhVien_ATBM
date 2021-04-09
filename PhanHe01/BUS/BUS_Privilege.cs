using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using DAO;
using System.Collections.ObjectModel;

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

        public ObservableCollection<DTO_PrivilegeOnTable> GetPrivilegesOnTable(String username)
        {
            //Get all data from DAO Layer
            ObservableCollection<DTO_PrivilegeOnTable> result = new ObservableCollection<DTO_PrivilegeOnTable>();
            DataTable data = DAO_Privilege.Instance.GetPrivilegeOnTable(username);

            foreach (DataRow row in data.Rows)
            {
                bool flag = false;
                DTO_PrivilegeOnTable tmpObject = new DTO_PrivilegeOnTable();

                tmpObject.TableName = row["TABLE_NAME"].ToString();
                tmpObject.Grantor = row["GRANTOR"].ToString();
                if(result.Count > 0 && result[result.Count - 1].TableName.Equals(tmpObject.TableName)) {
                    tmpObject = result[result.Count - 1];
                    flag = true;
                }

                String privilege = row["PRIVILEGE"].ToString();
                String grantable = row["GRANTABLE"].ToString();

                //All default values were false
                if(privilege.Equals("SELECT"))
                {
                    tmpObject.IsSelect = true;
                    if(grantable.Equals("YES"))
                    {
                        tmpObject.IsSelectGrantable = true;
                    }
                }
                else if (privilege.Equals("INSERT"))
                {
                    tmpObject.IsInsert = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsInsertGrantable = true;
                    }
                }
                else if (privilege.Equals("UPDATE"))
                {
                    tmpObject.IsUpdate = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsUpdateGrantable = true;
                    }
                }
                else
                {
                    tmpObject.IsDelete = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsDeleteGrantable = true;
                    }
                }

                if(!flag)
                {
                    result.Add(tmpObject);
                }

            }

            return result;
        }

        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegeOnColumn(String username)
        {
            //Get all data from DAO Layer
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            DataTable data = DAO_Privilege.Instance.GetPrivilegeOnColumn(username);

            foreach (DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmpObject = new DTO_PrivilegeOnColumn();

                tmpObject.TableName = row["TABLE_NAME"].ToString();
                tmpObject.Grantor = row["GRANTOR"].ToString();
                tmpObject.ColumnName = row["COLUMN_NAME"].ToString();
                tmpObject.Privilege = row["PRIVILEGE"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }
    }

}
