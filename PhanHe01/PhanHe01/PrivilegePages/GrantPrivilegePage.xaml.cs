using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for GrantPrivilegePage.xaml
    /// </summary>
    public partial class GrantPrivilegePage : Page
    {
        public GrantPrivilegePage()
        {
            InitializeComponent();
        }

        private ObservableCollection<DTO_PrivilegeOnTable> privilegesOnTableList = null;

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkExistUser = BUS_User.Instance.CheckUser(UsernameTextBox.Text);
            if(!checkExistUser)
            {
                bool checkExistRole = BUS_Role.Instance.CheckRole(UsernameTextBox.Text);
                if(!checkExistRole)
                {
                    MessageBox.Show("KHÔNG TÌM THẤY USER/ROLE NÀY!", "Oops");
                    return;
                }
            }
            PrivilegeTableStackPanel.Visibility = Visibility;
            privilegesOnTableList = BUS_Privilege.Instance.GetPrivilegesAllTables(UsernameTextBox.Text);
            PrivilegeOnTable_DataGrid.ItemsSource = privilegesOnTableList;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            BUS_Privilege.Instance.ExecPrivilegeOnTable(privilegesOnTableList, null, UsernameTextBox.Text);
            MessageBox.Show($"Successfully!");
        }
    }
}
