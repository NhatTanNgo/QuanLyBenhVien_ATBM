using BUS;
using DTO;
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
    /// Interaction logic for VPD_MedicalRecord.xaml
    /// </summary>
    public partial class VPD_MedicalRecord : Page
    {
        public VPD_MedicalRecord()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadMedicalReords();
        }

        private void LoadMedicalReords()
        {
            try
            {
                List<DTO_PhieuKhamBenh> medicalRecords = BUS_PhieuKhamBenh.Instance.GetMedicalRecords();
                medicalRecord_grid.ItemsSource = medicalRecords;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadMedicalReords();
        }
    }
}
