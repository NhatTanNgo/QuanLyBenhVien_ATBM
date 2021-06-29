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
    /// Interaction logic for GUI_FinStaffsPage.xaml
    /// </summary>
    public partial class GUI_FinStaffsPage : Page
    {
        public GUI_FinStaffsPage()
        {
            InitializeComponent();
        }

        private List<DTO_NhanVien> finStaffList = null;

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadFinStaffs();
        }

        private void LoadFinStaffs()
        {
            try
            {
                finStaffList = BUS_NhanVien.Instance.GetFinanceEmployees();
                FinStaffsDataGrid.AutoGenerateColumns = false;
                FinStaffsDataGrid.ItemsSource = finStaffList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadFinStaffs();
        }
    }
}
