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
    /// Interaction logic for GrantRoleToUserPage.xaml
    /// </summary>
    public partial class GrantRoleToUserPage : Page
    {
        public GrantRoleToUserPage()
        {
            InitializeComponent();
        }

        private List<DTO_Role> roleList;
        private List<DTO_User> userList;
        private List<ObjectToGrant> list = new List<ObjectToGrant>();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                roleList = BUS_Role.Instance.GetAllRoles();
                userList = BUS_User.Instance.GetAllUsers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            for(int i = 0; i < roleList.Count; i++)
            {
                ObjectToGrant tmp = new ObjectToGrant(roleList[i].RoleName);
                list.Add(tmp);
            }
            for (int i = 0; i < userList.Count; i++)
            {
                ObjectToGrant tmp = new ObjectToGrant(userList[i].Username);
                list.Add(tmp);
            }

            RoleNameComboBox.ItemsSource = roleList;
            RoleOrUsernameComboBox.ItemsSource = list;

        }


        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            
            int roleIndex = RoleNameComboBox.SelectedIndex;
            String role = roleList[roleIndex].RoleName;
            int grantedIndex = RoleOrUsernameComboBox.SelectedIndex;
            String granted = list[grantedIndex].Name;
            bool? grantOpt = grantOpt_checkbox.IsChecked;
            if(role.Equals("") || granted.Equals("") )
            {
                return;
            }
            try
            {
                BUS_Role.Instance.GrantRoleToUser(role, granted, grantOpt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Grant succeeded.");
        }

        private class ObjectToGrant
        {
            public String Name { get; set; }
            public ObjectToGrant(String name)
            {
                this.Name = name;
            }
        }
    }
}
