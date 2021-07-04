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

namespace HeThongBenhVien.FinanceManagement
{
    /// <summary>
    /// Interaction logic for GUI_ServicePage.xaml
    /// </summary>
    public partial class GUI_ServicePage : Page
    {
        public GUI_ServicePage()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadServiceInfor();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadServiceInfor()
        {
            try
            {
                List<DTO_DichVu> serviceInfor = BUS_DichVu.Instance.GetServiceInfor();
                ServiceDataGrid.AutoGenerateColumns = false;
                ServiceDataGrid.ItemsSource = serviceInfor;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AddServiceButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DelServiceButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
