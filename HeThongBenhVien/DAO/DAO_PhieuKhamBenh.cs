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
                if(_instance == null)
                {
                    _instance = new DAO_PhieuKhamBenh();
                }
                return _instance;
            }
        }

        public DataTable GetMedicalRecords()
        {
            _conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"select * from ot.phieukhambenh";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }
    }
}
