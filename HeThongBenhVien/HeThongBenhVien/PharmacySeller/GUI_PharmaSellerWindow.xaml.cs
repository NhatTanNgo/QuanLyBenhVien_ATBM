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
            SearchPresciptions();
        }
        private void LoadPrescriptions()
        {
            try
            {
                PrescriptionList = BUS_ToaThuoc.Instance.GetPrescriptions();
                PrescriptionsDataGrid.AutoGenerateColumns = false;
                PrescriptionsDataGrid.ItemsSource = PrescriptionList;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void SearchPresciptions()
        {
            try
            {
                PrescriptionList = BUS_ToaThuoc.Instance.GetPrescriptionByMakhambenh((MaPK.Text).ToUpper());
                PrescriptionsDataGrid.AutoGenerateColumns = false;
                PrescriptionsDataGrid.ItemsSource = PrescriptionList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPrescriptions();
        }
        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
