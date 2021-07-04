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

                DateTime date = DateTime.Parse(row["NGAYKHAM"].ToString());
                tmpObject.NgayKham = date.ToString("dd/MM/yyyy");

                tmpObject.TrieuChung = Crypto.Decryption(row["TRIEUCHUNG"].ToString(), Crypto.CryptoKey);
                tmpObject.KetLuanCuaBacSi = Crypto.Decryption(row["KETLUANCUABACSI"].ToString(), Crypto.CryptoKey);

                tmpObject.MaBenhNhan = row["MABENHNHAN"].ToString();
                tmpObject.MaBacSi = row["MANHANVIEN"].ToString();

                result.Add(tmpObject);
            }
            return result;
        }

        public void InsertMedicalRecord(DTO_PhieuKhamBenh medicalRecord)
        {
            //Encrypt
            String cypherSymptoms = Crypto.Encryption(medicalRecord.TrieuChung, Crypto.CryptoKey);
            String cypherDiagnose = Crypto.Encryption(medicalRecord.KetLuanCuaBacSi, Crypto.CryptoKey);

            medicalRecord.TrieuChung = cypherSymptoms;
            medicalRecord.KetLuanCuaBacSi = cypherDiagnose;

            DAO_PhieuKhamBenh.Instance.InsertMedicalRecord(medicalRecord);
        }
    }
}
