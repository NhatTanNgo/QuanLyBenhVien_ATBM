﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeThongBenhVien.MainDemo
{
    /// <summary>
    /// Interaction logic for Encrypt_InsertMedicalRecord.xaml
    /// </summary>
    public partial class Encrypt_InsertMedicalRecord : Page
    {
        public Encrypt_InsertMedicalRecord()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            DTO_PhieuKhamBenh medicalRecord = new DTO_PhieuKhamBenh();

            medicalRecord.MaKhamBenh = txtbox_medicalRecordID.Text;
            medicalRecord.MaBenhNhan = txtbox_patientID.Text;
            medicalRecord.MaBacSi = txtbox_doctorID.Text;
            medicalRecord.TrieuChung = txtbox_symptompsID.Text;
            medicalRecord.KetLuanCuaBacSi = txtbox_diagnoseID.Text;

            //Call BUS to do encrypt
        }
    }
}
