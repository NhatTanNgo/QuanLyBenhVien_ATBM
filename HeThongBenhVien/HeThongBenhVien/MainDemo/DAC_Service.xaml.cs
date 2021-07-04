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
    /// Interaction logic for DAC_Service.xaml
    /// </summary>
    public partial class DAC_Service : Page
    {
        public DAC_Service()
        {
            InitializeComponent();
        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadServices();
        }
        private void LoadServices()
        {
            try
            {
                List<DTO_DichVu> Drugs = BUS_DichVu.Instance.GetServiceInfor();
                services_grid.ItemsSource = Drugs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadServices();
        }
    }
}
