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
    public class BUS_Thuoc
    {
        private static BUS_Thuoc _instance = null;
        public static BUS_Thuoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Thuoc();
                }
                return _instance;
            }
        }
        public List<DTO_Thuoc> GetDrugs()
        {
            List<DTO_Thuoc> result = new List<DTO_Thuoc>();
            DataTable data = DAO_Thuoc.Instance.GetDrugs();

            foreach (DataRow row in data.Rows)
            {
                DTO_Thuoc tmpObject = new DTO_Thuoc();
                tmpObject.MaThuoc = row["MATHUOC"].ToString();
                tmpObject.TenThuoc = row["TENTHUOC"].ToString();

                tmpObject.DonGia = double.Parse(row["DONGIA"].ToString());
                tmpObject.DonViTinh = row["DONVITINH"].ToString();
                tmpObject.LuuY = row["LUUY"].ToString();
                result.Add(tmpObject);
            }
            return result;
        }
    }
}
