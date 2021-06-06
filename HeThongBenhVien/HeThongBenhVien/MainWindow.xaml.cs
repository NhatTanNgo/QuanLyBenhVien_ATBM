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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace HeThongBenhVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String _username = null;
        public MainWindow(String username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_username.Text += _username;
        }

        private void btn_left_Click(object sender, RoutedEventArgs e)
        {
            btn_right.Visibility = Visibility.Visible;
            btn_left.Visibility = Visibility.Hidden;
        }

        private void btn_right_Click(object sender, RoutedEventArgs e)
        {
            btn_right.Visibility = Visibility.Hidden;
            btn_left.Visibility = Visibility.Visible;
        }
    }
}
