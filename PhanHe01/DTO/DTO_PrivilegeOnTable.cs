using System;

namespace DTO
{
    public class DTO_PrivilegeOnTable
    {
        public String TableName { get; set; }
        public bool IsSelect { get; set; }
        public bool IsInsert { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsDelete { get; set; }

        public DTO_PrivilegeOnTable()
        {
            IsSelect = false;
            IsInsert = false;
            IsUpdate = false;
            IsDelete = false;
        }
    }
}
