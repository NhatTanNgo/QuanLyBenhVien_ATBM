using BUS;
using DTO;
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
    /// Interaction logic for RevokeRolePage.xaml
    /// </summary>
    public partial class RevokeRolePage : Page
    {
        public RevokeRolePage()
        {
            InitializeComponent();
        }

        private List<DTO_Role> roleList;
        private List<DTO_User> userList;
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                roleList = BUS_Role.Instance.GetAllRoles();
                userList = BUS_User.Instance.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            RoleNameComboBox.ItemsSource = roleList;
            UsernameComboBox.ItemsSource = userList;

        }


        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {

            int roleIndex = RoleNameComboBox.SelectedIndex;

            if(roleIndex < 0)
            {
                roleIndex = 0;
            }
            String role = roleList[roleIndex].RoleName;
            int userIndex = UsernameComboBox.SelectedIndex;
            if(userIndex < 0)
            {
                userIndex = 0;
            }    
            String username = userList[userIndex].Username;
            if (role.Equals("") || username.Equals(""))
            {
                return;
            }
            try
            {
                BUS_Role.Instance.RevokeRoleToUser(role, username);
                roleList = BUS_Role.Instance.GetRolesOfUser(username);
                RoleNameComboBox.ItemsSource = roleList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Revoke succeeded.");
        }



        private void UsernameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int userIndex = UsernameComboBox.SelectedIndex;
            String user = userList[userIndex].Username;
            if (user.Equals(""))
            {
                return;
            }
            roleList = BUS_Role.Instance.GetRolesOfUser(user);
            RoleNameComboBox.ItemsSource = roleList;
        }
        bool handled = true;
        private void UsernameComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if(handled)
            {
                RoleNameComboBox.ItemsSource = roleList;
                handled = false;
            }    
        }
    }
}

