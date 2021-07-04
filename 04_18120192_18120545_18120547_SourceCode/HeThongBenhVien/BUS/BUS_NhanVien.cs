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

        public List<DTO_NhanVien> GetFinanceEmployees()
        {
            //Get all data from DAO Layer
            List<DTO_NhanVien> result = new List<DTO_NhanVien>();
            DataTable data = DAO_NhanVien.Instance.GetFinanceEmployees();

            foreach (DataRow row in data.Rows)
            {
                DTO_NhanVien tmpObject = new DTO_NhanVien();

                tmpObject.MaNhanVien = row["MANHANVIEN"].ToString();
                tmpObject.HoTen = row["HOTEN"].ToString();
                tmpObject.SDT = row["SDT"].ToString();
                tmpObject.DiaChi = row["DIACHI"].ToString();
                tmpObject.Email = row["EMAIL"].ToString();
                tmpObject.DOB = row["DOB"].ToString();
                tmpObject.LuongCoBan = double.Parse(row["LUONGCOBAN"].ToString());
                tmpObject.PhuCap = double.Parse(row["LUONGCOBAN"].ToString());

                result.Add(tmpObject);
            }

            return result;
        }

        public List<DTO_NhanVien> GetEmployees()
        {
            //Get all data from DAO Layer
            List<DTO_NhanVien> result = new List<DTO_NhanVien>();
            DataTable data = DAO_NhanVien.Instance.GetEmployees();

            foreach (DataRow row in data.Rows)
            {
                DTO_NhanVien tmpObject = new DTO_NhanVien();

                tmpObject.MaNhanVien = row["MANHANVIEN"].ToString();
                tmpObject.HoTen = row["HOTEN"].ToString();
                tmpObject.SDT = row["SDT"].ToString();
                tmpObject.DiaChi = row["DIACHI"].ToString();
                tmpObject.Email = row["EMAIL"].ToString();

                DateTime date = DateTime.Parse(row["DOB"].ToString());
                tmpObject.DOB = date.ToString("dd/MM/yyyy");
                tmpObject.LuongCoBan = double.Parse(row["LUONGCOBAN"].ToString());
                tmpObject.PhuCap = double.Parse(row["LUONGCOBAN"].ToString());
                tmpObject.MaBoPhan = row["MABOPHAN"].ToString();
                tmpObject.ChiNhanh = row["CHINHANH"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }
    }
}
