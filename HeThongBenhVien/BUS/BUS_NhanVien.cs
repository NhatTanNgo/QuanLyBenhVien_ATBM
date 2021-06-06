using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        // Singleton
        private static BUS_NhanVien _instance = null;
        public static BUS_NhanVien Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BUS_NhanVien();
                }
                return _instance;
            }
        }

        public void Login(String username, String password, String dbName)
        {
            DAO.DBConnect.InitConnection(username, password, dbName);
        }
    }
}
