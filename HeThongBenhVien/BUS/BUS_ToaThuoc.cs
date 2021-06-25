using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class BUS_ToaThuoc
    {
        private static BUS_ToaThuoc _instance = null;
        public static BUS_ToaThuoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_ToaThuoc();
                }
                return _instance;
            }
        }
       
    }
}
