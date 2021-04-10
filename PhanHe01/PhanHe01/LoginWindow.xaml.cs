using BUS;
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

namespace PhanHe01
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
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
                BUS_User.Instance.Login(username, password, dbname);
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
    }
}
