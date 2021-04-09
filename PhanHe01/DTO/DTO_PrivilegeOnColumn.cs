using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_PrivilegeOnColumn
    {
        public String TableName { get; set; }
        public String ColumnName { get; set; }
        public bool IsSelect { get; set; }
        public bool IsInsert { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsGrantable { get; set; }
        public String Grantor { get; set; }
        public String Privilege { get; set; }

        public DTO_PrivilegeOnColumn()
        {
            IsSelect = false;
            IsInsert = false;
            IsUpdate = false;
            IsDelete = false;
            IsGrantable = false;
        }
    }
}
