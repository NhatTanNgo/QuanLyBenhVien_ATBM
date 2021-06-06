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
using BUS;

namespace HeThongBenhVien
{
    /// <summary>
    /// Interaction logic for GUI_LoginWindow.xaml
    /// </summary>
    public partial class GUI_LoginWindow : Window
    {
        public GUI_LoginWindow()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Password;

            String dbname = DBNameTextBox.Text;

            try
            {
                BUS_NhanVien.Instance.Login(username, password, dbname);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MainWindow mainWindow = new MainWindow(username);
            mainWindow.Show();
            this.Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ConnectButton_Click(sender, e);
            }
        }
    }
}
