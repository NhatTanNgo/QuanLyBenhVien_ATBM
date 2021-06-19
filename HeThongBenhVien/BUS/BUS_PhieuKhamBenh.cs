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
    public class BUS_PhieuKhamBenh
    {
        private static BUS_PhieuKhamBenh _instance = null;
        public static BUS_PhieuKhamBenh Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BUS_PhieuKhamBenh();
                }
                return _instance;
            }
        }

        public List<DTO_PhieuKhamBenh> GetMedicalRecords()
        {
            List<DTO_PhieuKhamBenh> result = new List<DTO_PhieuKhamBenh>();
            DataTable data = DAO_PhieuKhamBenh.Instance.GetMedicalRecords();

            foreach (DataRow row in data.Rows)
            {
                DTO_PhieuKhamBenh tmpObject = new DTO_PhieuKhamBenh();

                tmpObject.MaKhamBenh = row["MAKHAMBENH"].ToString();
                tmpObject.NgayKham = row["NGAYKHAM"].ToString();
                tmpObject.TrieuChung = row["TRIEUCHUNG"].ToString();
                tmpObject.KetLuanCuaBacSi = row["KETLUANCUABACSI"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }
    }
}
