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
    public class BUS_ToaThuoc
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
        public List<DTO_ToaThuoc> GetPrescriptions()
        {
            List<DTO_ToaThuoc> result = new List<DTO_ToaThuoc>();
            DataTable data = DAO_ToaThuoc.Instance.GetPrescriptions();

            foreach (DataRow row in data.Rows)
            {
                DTO_ToaThuoc tmpObject = new DTO_ToaThuoc();
                tmpObject.MaDonThuoc = row["MADONTHUOC"].ToString();
                tmpObject.NgayLapDon = row["NGAYLAPDON"].ToString();
                
                tmpObject.TongTien = double.Parse(row["TONGTIEN"].ToString());

                result.Add(tmpObject);
            }
            return result;
        }
    }
}
