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
    /// Interaction logic for DAC_Drugs.xaml
    /// </summary>
    public partial class DAC_Drugs : Page
    {
        public DAC_Drugs()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadDrugs();
        }
        private void LoadDrugs()
        {
            try
            {
                List<DTO_Thuoc> Drugs = BUS_Thuoc.Instance.GetDrugs();
                drugs_grid.ItemsSource = Drugs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDrugs();
        }
    }
}
