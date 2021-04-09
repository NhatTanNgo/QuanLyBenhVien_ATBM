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

namespace PhanHe01
{
    /// <summary>
    /// Interaction logic for ManageUserPage.xaml
    /// </summary>
    public partial class ManageUserPage : Page
    {
        public ManageUserPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UserPages.ShowPrivilegePage showPrivilegePage = new UserPages.ShowPrivilegePage();
            SubFrame.Navigate(showPrivilegePage);
        }

        private void ListUserButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.ShowUsersPage showUsersPage = new UserPages.ShowUsersPage();
            SubFrame.Navigate(showUsersPage);
        }

        private void CheckPrivilegeButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.ShowPrivilegePage showPrivilegePage = new UserPages.ShowPrivilegePage();
            SubFrame.Navigate(showPrivilegePage);
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.AddUserPage addUserPage = new UserPages.AddUserPage();
            SubFrame.Navigate(addUserPage);
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.DeleteUserPage deleteUserPage = new UserPages.DeleteUserPage();
            SubFrame.Navigate(deleteUserPage);
        }

        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.UpdateUserPage updateUserPage = new UserPages.UpdateUserPage();
            SubFrame.Navigate(updateUserPage);
        }

        private void AddRoleButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.AddRolePage addRolePage = new UserPages.AddRolePage();
            SubFrame.Navigate(addRolePage);
        }

        private void UpdateRoleButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteRoleButton_Click(object sender, RoutedEventArgs e)
        {
            UserPages.DeleteRolePage deleteRolePage = new UserPages.DeleteRolePage();
            SubFrame.Navigate(deleteRolePage);
        }
    }
}
