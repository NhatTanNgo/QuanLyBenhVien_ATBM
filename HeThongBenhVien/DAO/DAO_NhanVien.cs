﻿using System;
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
            _conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"select n.manhanvien, n.hoten, n.sdt, n.diachi, n.email, n.dob, n.luongcoban, n.phucap " +
                                    $"from {_dbSchema}.nhanvien n where n.mabophan = 'BP005'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }

        public DataTable GetEmployees()
        {
            _conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"select n.manhanvien, n.hoten, n.sdt, n.diachi, n.email, n.dob, n.luongcoban, n.phucap, t.tenbophan " +
                                    $"from {_dbSchema}.nhanvien n, ot.bophan t where t.mabophan = n.mabophan";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }
    }
}
