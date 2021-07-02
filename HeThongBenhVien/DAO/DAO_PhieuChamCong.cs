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
    public class DAO_PhieuChamCong : DBConnect
    {
        private static DAO_PhieuChamCong _instance = null;
        public static DAO_PhieuChamCong Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_PhieuChamCong();
                }
                return _instance;
            }
        }
        public DataTable GetTimeSheets()
        {
            try
            {
                _conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = $"select * from {_dbSchema}.phieuchamcong";
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
        public void InsertTimeSheet(DTO_PhieuChamCong TimeSheet)
        {
            OracleCommand command = new OracleCommand($"{_dbSchema}.INSERT_PCC", _conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("I_THOIGIAN", OracleDbType.Varchar2);
            param1.Value = TimeSheet.ThoiGian;
            OracleParameter param2 = new OracleParameter("I_SONGAYCONG", OracleDbType.Int16);
            param2.Value = TimeSheet.SoNgayCong;
            OracleParameter param3 = new OracleParameter("I_TIENLUONG", OracleDbType.Double);
            param2.Value = TimeSheet.TienLuong;

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
