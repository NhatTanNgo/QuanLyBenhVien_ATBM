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
    /// Interaction logic for DAC_ServiceView.xaml
    /// </summary>
    public partial class DAC_ServiceView : Page
    {
        public DAC_ServiceView()
        {
            InitializeComponent();
        }

        private void LoadServiceInfor()
        {
            try
            {
                List<DTO_DichVu> serviceInfor = BUS_DichVu.Instance.GetServiceInfor();
                ServiceDataGrid.AutoGenerateColumns = false;
                ServiceDataGrid.ItemsSource = serviceInfor;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadServiceInfor();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops");
                return;
            }

        }
    }
}
