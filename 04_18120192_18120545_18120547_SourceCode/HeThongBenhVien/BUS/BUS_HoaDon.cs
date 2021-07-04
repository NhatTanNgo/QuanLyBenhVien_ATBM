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
    public class BUS_HoaDon
    {
        private static BUS_HoaDon _instance = null;
        public static BUS_HoaDon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_HoaDon();
                }
                return _instance;
            }
        }

        public List<DTO_HoaDon> GetReceipts()
        {
            List<DTO_HoaDon> result = new List<DTO_HoaDon>();
            DataTable data = DAO_HoaDon.Instance.GetReceipts();

            foreach (DataRow row in data.Rows)
            {
                DTO_HoaDon tmpObject = new DTO_HoaDon();

                tmpObject.MaHoaDon = row["MAHOADON"].ToString();
                tmpObject.NgayLapHoaDon = row["NGAYLAPHOADON"].ToString();
                tmpObject.TongTien = double.Parse(row["TONGTIEN"].ToString());
                tmpObject.MaKhamBenh = row["MAKHAMBENH"].ToString();
                tmpObject.MaNhanVien = row["MANHANVIEN"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }
    }
}
