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
using System.Windows.Shapes;

namespace HeThongBenhVien.PharmacySeller
{
    /// <summary>
    /// Interaction logic for GUI_PharmaSellerWindow.xaml
    /// </summary>
    public partial class GUI_PharmaSellerWindow : Window
    {
        public GUI_PharmaSellerWindow()
        {
            InitializeComponent();
        }
        private List<DTO_ToaThuoc> PrescriptionList = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadPrescriptions();
        }
        private void LoadPrescriptions()
        {
            PrescriptionList = BUS_ToaThuoc.Instance.GetPrescriptions();
            PrescriptionsDataGrid.AutoGenerateColumns = false;
            PrescriptionsDataGrid.ItemsSource = PrescriptionList;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPrescriptions();
        }
    }
}
