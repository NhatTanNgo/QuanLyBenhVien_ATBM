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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhanHe01.UserPages
{
    /// <summary>
    /// Interaction logic for AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public AddUserPage()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Password;

            if(password.Trim().Equals(""))
            {
                MessageBox.Show("Password Require!");
                return;
            }

            try
            {
                BUS_User.Instance.CreateUser(username, password);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            MessageBox.Show($"{username} created successfully!");

        }
    }
}
