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
    /// Interaction logic for VPD_TimeSheet.xaml
    /// </summary>
    public partial class VPD_TimeSheet : Page
    {
        public VPD_TimeSheet()
        {
            InitializeComponent();
        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadTimeSheets();
        }

        private void LoadTimeSheets()
        {
            List<DTO_PhieuChamCong> medicalRecords = BUS_PhieuChamCong.Instance.GetTimeSheets();

            medicalRecord_grid.ItemsSource = medicalRecords;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadTimeSheets();
        }
    }
}
