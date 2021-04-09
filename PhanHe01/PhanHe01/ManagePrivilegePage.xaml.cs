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
    /// Interaction logic for ManagePrivilegePage.xaml
    /// </summary>
    public partial class ManagePrivilegePage : Page
    {
        public ManagePrivilegePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PrivilegePages.GrantPrivilegePage grantPrivilegePage = new PrivilegePages.GrantPrivilegePage();
            SubFrame.Navigate(grantPrivilegePage);
        }

        private void GrantRoleToUserButton_Click(object sender, RoutedEventArgs e)
        {
            PrivilegePages.GrantRoleToUserPage grantRoleToUserPage = new PrivilegePages.GrantRoleToUserPage();
            SubFrame.Navigate(grantRoleToUserPage);
        }
    }
}
