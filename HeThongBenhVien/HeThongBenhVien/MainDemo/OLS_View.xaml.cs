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
    /// Interaction logic for OLS_View.xaml
    /// </summary>
    public partial class OLS_View : Page
    {
        public OLS_View()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadEmployees();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            List<DTO_NhanVien> employeeList = BUS_NhanVien.Instance.GetEmployees();
            EmployeeDataGrid.ItemsSource = employeeList;
        }
    }
}
