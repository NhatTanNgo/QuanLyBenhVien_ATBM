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

namespace PhanHe01.PrivilegePages
{
    /// <summary>
    /// Interaction logic for SeeRolePage.xaml
    /// </summary>
    public partial class SeeRolePage : Page
    {
        public SeeRolePage()
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
            Role_DataGrid.ItemsSource = BUS_Role.Instance.GetRolesOfUser(UsernameTextBox.Text);

        }
    }
}
