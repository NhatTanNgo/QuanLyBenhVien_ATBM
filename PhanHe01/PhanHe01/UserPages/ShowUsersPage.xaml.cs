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
    /// Interaction logic for ShowUsersPage.xaml
    /// </summary>
    public partial class ShowUsersPage : Page
    {
        public ShowUsersPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListUsers_DataGrid.ItemsSource = BUS_User.Instance.GetAllUsers();
            ListRoles_DataGrid.ItemsSource = BUS_Role.Instance.GetAllRoles();
        }
    }
}
