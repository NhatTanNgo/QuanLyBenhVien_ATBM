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
    public class BUS_PhieuChamCong
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
        public List<DTO_PhieuChamCong> GetTimeSheets()
        {
            List<DTO_PhieuChamCong> result = new List<DTO_PhieuChamCong>();
            DataTable data = DAO_PhieuChamCong.Instance.GetTimeSheets();

            foreach (DataRow row in data.Rows)
            {
                DTO_PhieuChamCong tmpObject = new DTO_PhieuChamCong();
                DateTime date = DateTime.Parse(row["THOIGIAN"].ToString());
                tmpObject.ThoiGian = date.ToString("dd/MM/yyyy");

                tmpObject.SoNgayCong = int.Parse(row["SONGAYCONG"].ToString());
                tmpObject.TienLuong = double.Parse(row["SONGAYCONG"].ToString());

                result.Add(tmpObject);
            }
            return result;
        }

    }

}
