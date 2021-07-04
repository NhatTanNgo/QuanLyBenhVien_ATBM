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
    /// Interaction logic for UpdateUserPage.xaml
    /// </summary>
    public partial class UpdateUserPage : Page
    {
        public UpdateUserPage()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkExistUser = BUS_User.Instance.CheckUser(UsernameTextBox.Text);
            if (!checkExistUser)
            {
                MessageBox.Show("KHÔNG TÌM THẤY USER NÀY!", "Oops");
                return;
            }

            SettingUserStackPanel.Visibility = Visibility;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BUS_User.Instance.UpdateUser(UsernameTextBox.Text, (bool)LockRadioButton.IsChecked, NewPasswordTextBox.Password);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"Update {UsernameTextBox.Text} successfully!");
        }
    }
}
