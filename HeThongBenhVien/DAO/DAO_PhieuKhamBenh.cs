using DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_PhieuKhamBenh : DBConnect
    {
        private static DAO_PhieuKhamBenh _instance = null;
        public static DAO_PhieuKhamBenh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_PhieuKhamBenh();
                }
                return _instance;
            }
        }

        public DataTable GetMedicalRecords()
        {
            try
            {
                _conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = $"select * from {_dbSchema}.phieukhambenh";
                command.Connection = _conn;

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
                _conn.Close();
                return dataTable;
            }
            catch(OracleException e)
            {
                _conn.Close();
                throw e;
            }
        }

        public void InsertMedicalRecord(DTO_PhieuKhamBenh medicalRecord)
        {
            ////OracleCommand command = new OracleCommand();
            //command.CommandText = $"begin INSERT_PKB ('{medicalRecord.MaKhamBenh}', '{medicalRecord.NgayKham}', '{medicalRecord.TrieuChung}', " +
            //                                       $"'{medicalRecord.KetLuanCuaBacSi}', '{medicalRecord.MaBenhNhan}', '{medicalRecord.MaBacSi}'); end;";
            //command.Connection = _conn;
            
            OracleCommand command = new OracleCommand($"{_dbSchema}.INSERT_PKB", _conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("I_MAKHAMBENH", OracleDbType.Varchar2);
            param1.Value = medicalRecord.MaKhamBenh;
            OracleParameter param2 = new OracleParameter("I_NGAYKHAM", OracleDbType.Varchar2);
            param2.Value = medicalRecord.NgayKham;
            OracleParameter param3 = new OracleParameter("I_TRIEUCHUNG", OracleDbType.Varchar2);
            param3.Value = medicalRecord.TrieuChung;
            OracleParameter param4 = new OracleParameter("I_KETLUANCUABS", OracleDbType.Varchar2);
            param4.Value = medicalRecord.KetLuanCuaBacSi;
            OracleParameter param5 = new OracleParameter("I_MABENHNHAN", OracleDbType.Varchar2);
            param5.Value = medicalRecord.MaBenhNhan;
            OracleParameter param6 = new OracleParameter("I_MANHANVIEN", OracleDbType.Varchar2);
            param6.Value = medicalRecord.MaBacSi;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                _conn.Close();
                throw new Exception(e.Message);
            }
        }
    }
}
