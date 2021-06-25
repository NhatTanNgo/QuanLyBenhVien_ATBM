using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    class BUS_PhieuChamCong
    {
        private static BUS_PhieuChamCong _instance = null;
        public static BUS_PhieuChamCong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_PhieuChamCong();
                }
                return _instance;
            }
        }
    }
}
