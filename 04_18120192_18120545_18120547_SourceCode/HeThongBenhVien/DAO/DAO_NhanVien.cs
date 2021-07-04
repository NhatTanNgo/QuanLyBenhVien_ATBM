using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public class DAO_NhanVien : DBConnect
    {
        private static DAO_NhanVien _instance = null;
        public static DAO_NhanVien Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAO_NhanVien();
                }
                return _instance;
            }
        }

        public DataTable GetFinanceEmployees()
        {
            try
            {
                _conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = $"select manhanvien, hoten, sdt, diachi, email, dob, luongcoban, phucap " +
                                        $"from {_dbSchema}.nhanvien where mabophan = 'BP005'";
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

        public DataTable GetEmployees()
        {
            try
            {
                _conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = $"select * " +
                                        $"from {_dbSchema}.nhanvien";
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
    }
}
