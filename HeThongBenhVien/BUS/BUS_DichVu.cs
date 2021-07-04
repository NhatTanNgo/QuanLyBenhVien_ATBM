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
    public class BUS_DichVu
    {
        private static BUS_DichVu _instance = null;
        public static BUS_DichVu Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BUS_DichVu();
                }
                return _instance;
            }
        }

        public List<DTO_DichVu> GetServiceInfor()
        {
            List<DTO_DichVu> result = new List<DTO_DichVu>();
            DataTable data = DAO_DichVu.Instance.GetServiceInfor();

            foreach (DataRow row in data.Rows)
            {
                DTO_DichVu tmpObject = new DTO_DichVu();

                tmpObject.MaDichVu = row["MADICHVU"].ToString();
                tmpObject.TenDichVu = row["TENDICHVU"].ToString();
                tmpObject.GiaTien = double.Parse(row["GIATIEN"].ToString());

                result.Add(tmpObject);
            }

            return result;
        }
    }
}
