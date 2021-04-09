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
    /// Interaction logic for DeleteUserPage.xaml
    /// </summary>
    public partial class DeleteUserPage : Page
    {
        public DeleteUserPage()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            String username = UsernameTextBox.Text.ToUpper();

            if (username.Trim().Equals(""))
            {
                MessageBox.Show("Username Require!");
                return;
            }

            try
            {
                BUS_User.Instance.DeleteUser(username, CascadeCheckBox.IsEnabled);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{username} droped successfully!");

        }
    }
}
