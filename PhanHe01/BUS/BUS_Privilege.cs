using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using DAO;
using System.Collections.ObjectModel;
using System.Text;

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

        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegeOnColumnUpdateInsert(String username)
        {
            //Get all data from DAO Layer
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            DataTable data = DAO_Privilege.Instance.GetPrivilegeOnColumnUpdateInsert(username);

            foreach (DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmpObject = new DTO_PrivilegeOnColumn();

                tmpObject.TableName = row["TABLE_NAME"].ToString();
                tmpObject.Grantor = row["GRANTOR"].ToString();
                tmpObject.ColumnName = row["COLUMN_NAME"].ToString();
                tmpObject.Privilege = row["PRIVILEGE"].ToString();
                String grantable = row["GRANTABLE"].ToString();
                if(tmpObject.Privilege.Equals("UPDATE"))
                {
                    tmpObject.IsUpdate = true;
                    if(grantable.Equals("YES"))
                    {
                        tmpObject.IsUpdateGrantable = true;
                    }
                }
                if(tmpObject.Privilege.Equals("INSERT"))
                {
                    tmpObject.IsInsert = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsInsertGrantable = true;
                    }
                }

                result.Add(tmpObject);
            }

            return result;
        }

        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegesOnColumnSelect(String username)
        {
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            DataTable data = DAO_Privilege.Instance.GetPrivilegeOnView(username);

            foreach (DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmpObject = new DTO_PrivilegeOnColumn();
                String tableName = "", columnName = "";
                GetNameFromViewName(ref tableName, ref columnName, row["TABLE_NAME"].ToString());

                if(tableName == null || columnName == null)
                {
                    continue;
                }

                tmpObject.TableName = tableName;
                tmpObject.Grantor = row["GRANTOR"].ToString();
                tmpObject.ColumnName = columnName;
                tmpObject.Privilege = row["PRIVILEGE"].ToString();
                String grantable = row["GRANTABLE"].ToString();
                if (tmpObject.Privilege.Equals("SELECT"))
                {
                    tmpObject.IsSelect = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsSelectGrantable = true;
                    }
                }
                result.Add(tmpObject);
            }

            return result;
        }

        private void GetNameFromViewName(ref String TableName, ref String ColumnName, String ViewName)
        {
            int index0 = ViewName.IndexOf('_');
            if(index0 < 0)
            {
                TableName = null;
                ColumnName = null;
                return;
            }
            TableName = ViewName.Substring(0, index0);
            ViewName = ViewName.Substring(index0 + 1);
            index0 = ViewName.IndexOf('_');
            if (index0 < 0)
            {
                TableName = null;
                ColumnName = null;
                return;
            }
            ColumnName = ViewName.Substring(0, index0);

        }

        public ObservableCollection<DTO_PrivilegeOnTable> GetPrivilegesAllTables(String username)
        {
            ObservableCollection<DTO_PrivilegeOnTable> result = GetPrivilegesOnTable(username);
            DataTable data = DAO_Table.Instance.GetAllTables();
            bool flag = false;

            foreach(DataRow row in data.Rows)
            {
                DTO_PrivilegeOnTable tmpObject = new DTO_PrivilegeOnTable();
                tmpObject.TableName = row["OBJECT_NAME"].ToString();
                flag = false;

                for(int i = 0; i < result.Count; i++)
                {
                    if (result[i].TableName.Equals(tmpObject.TableName))
                    {
                        flag = true;
                        break;
                    }
                }

                if(!flag)
                {
                    result.Add(tmpObject);
                }
            }
            
            return result;
        }

        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegeOnColumns(String username)
        {
            ObservableCollection<DTO_PrivilegeOnColumn> result = GetPrivilegesOnColumnSelect(username);

            ObservableCollection<DTO_PrivilegeOnColumn> temp = GetPrivilegeOnColumnUpdateInsert(username);

            for(int i = 0; i < temp.Count; i++)
            {
                DTO_PrivilegeOnColumn objResult = temp[i];
                bool flag = false;
                for(int j = 0; j < result.Count; j++)
                {
                    DTO_PrivilegeOnColumn objTemp = result[j];
                    if (objResult.TableName.Equals(objTemp.TableName) &&
                        objResult.ColumnName.Equals(objTemp.ColumnName))
                    {
                        objResult.IsUpdate = objTemp.IsUpdate;
                        objResult.IsUpdateGrantable = objTemp.IsUpdateGrantable;
                        objResult.IsInsert = objTemp.IsInsert;
                        objResult.IsInsertGrantable = objTemp.IsInsertGrantable;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    result.Add(objResult);
                }
            }

            return result;
        }


        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegesAllColumns(String username, String tableName)
        {
            ObservableCollection<DTO_PrivilegeOnColumn> privilegeOnColumns = GetPrivilegeOnColumns(username);
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            for (int i = 0; i < privilegeOnColumns.Count; i++)
            {
                if (privilegeOnColumns[i].TableName.Equals(tableName))
                {
                    result.Add(privilegeOnColumns[i]);
                }
            }

            DataTable data = DAO_Table.Instance.GetAllColumnFromTable(tableName);
            foreach(DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmp = new DTO_PrivilegeOnColumn();
                tmp.TableName = tableName;
                tmp.ColumnName = row["column_name"].ToString();
                bool flag = false;

                for(int i =0; i < result.Count; i++)
                {
                    if(tmp.ColumnName.Equals(result[i].ColumnName))
                    {
                        flag = true;
                        break;
                    }
                }

                if(!flag)
                {
                    result.Add(tmp);
                }
            }
            return result;
            
        }

        public void ExecPrivilegeOnTable(ObservableCollection<DTO_PrivilegeOnTable> privilegesOnTable,
                                         String username)
        {
            RevokeAllPrivilegesTable(username);

            for(int i =0; i< privilegesOnTable.Count; i++)
            {
                DTO_PrivilegeOnTable tmp = privilegesOnTable[i];

                String privileges = "";
                if(tmp.IsSelect)
                {
                    privileges = "SELECT";
                    DAO_Privilege.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsSelectGrantable);
                }
                if (tmp.IsUpdate)
                {
                    privileges = "UPDATE";
                    DAO_Privilege.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsUpdateGrantable);
                }
                if (tmp.IsInsert)
                {
                    privileges = "INSERT";
                    DAO_Privilege.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsInsertGrantable);
                }
                if (tmp.IsDelete)
                {
                    privileges = "DELETE";
                    DAO_Privilege.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsDeleteGrantable);
                }
            }
        }

        public void ExecPrivilegeOnColumn(List<ObservableCollection<DTO_PrivilegeOnColumn>> privilegeOnColumns, String username)
        {
            for(int i =0; i < privilegeOnColumns.Count; i++)
            {
                for(int j = 0; j < privilegeOnColumns[i].Count; j++)
                {
                    DTO_PrivilegeOnColumn privilege = privilegeOnColumns[i][j];
                    if(privilege.IsUpdate)
                    {
                       
                            DAO_Privilege.Instance.GrantPrivilegeUpdateOnColumn
                               (username, privilege.TableName, privilege.ColumnName, privilege.IsUpdateGrantable);
                        
                       
                    }
                    
                    
                }


                for (int j = 0; j < privilegeOnColumns[i].Count; j++)
                {
                    DTO_PrivilegeOnColumn privilege = privilegeOnColumns[i][j];
                    if(privilege.IsSelect)
                    {
                        
                            DAO_Privilege.Instance.GrantPrivilegeSelectOnColumn
                               (username, privilege.TableName, privilege.ColumnName, privilege.IsSelectGrantable);
                        
                        
                    }
                   
                }
            }
        }

        public void RevokeAllPrivilegesTable(String username)
        {
            DataTable data = DAO_Table.Instance.GetAllTableGranted(username);
            foreach(DataRow row in data.Rows)
            {
                DAO_Privilege.Instance.RevokeAllPrivilegesOnTable(username, row["TABLE_NAME"].ToString());
            }
        }
    }
}
