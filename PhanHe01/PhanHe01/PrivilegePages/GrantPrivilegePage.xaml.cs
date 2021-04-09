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

        private ObservableCollection<DTO_PrivilegeOnTable> myList = null;

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkExistUser = BUS_User.Instance.CheckUser(UsernameTextBox.Text);
            if(!checkExistUser)
            {
                bool checkExistRole = BUS_Role.Instance.CheckRole(UsernameTextBox.Text);
                if(!checkExistUser)
                {
                    MessageBox.Show("KHÔNG TÌM THẤY USER/ROLE NÀY!", "Oops");
                    return;
                }
            }
            PrivilegeTableStackPanel.Visibility = Visibility;
            myList = BUS_Privilege.Instance.GetPrivilegesOnTable(UsernameTextBox.Text);
            PrivilegeOnTable_DataGrid.ItemsSource = myList;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
