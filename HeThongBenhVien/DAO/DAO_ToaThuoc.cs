using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public class DAO_ToaThuoc : DBConnect
    {
        private static DAO_ToaThuoc _instance = null;
        public static DAO_ToaThuoc Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_ToaThuoc();
                }
                return _instance;
            }
        }
        public DataTable GetPrescriptions()
        {
            _conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"select * from ot.toathuoc";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }
        public DataTable GetPrescriptionByMaKhamBenh(string MaKhamBenh)
        {
            _conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"select * from ot.toathuoc where MaKhamBenh = {MaKhamBenh}";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }
        public void InsertPrescription(DTO_ToaThuoc Prescription)
        {
            OracleCommand command = new OracleCommand("OT.INSERT_TT", _conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("I_MADONTHUOC", OracleDbType.Varchar2);
            param1.Value = Prescription.MaDonThuoc;
            OracleParameter param2 = new OracleParameter("I_NGAYLAPDON", OracleDbType.Varchar2);
            param2.Value = Prescription.NgayLapDon;
            OracleParameter param3 = new OracleParameter("I_TRIEUCHUNG", OracleDbType.Int16);
            param3.Value = Prescription.TongTien;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

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
