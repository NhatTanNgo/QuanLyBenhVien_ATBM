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
using BUS;
using DTO;

namespace PhanHe01.UserPages
{
    /// <summary>
    /// Interaction logic for ShowPrivilegePage.xaml
    /// </summary>
    public partial class ShowPrivilegePage : Page
    {
        public ShowPrivilegePage()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            String username = UsernameTextBox.Text;

            ObservableCollection<DTO_PrivilegeOnTable> privilegeOnTables = 
                BUS_Privilege.Instance.GetPrivilegesOnTable(username);
            ObservableCollection<DTO_PrivilegeOnColumn> privilegeOnColumns =
                BUS_Privilege.Instance.GetPrivilegeOnColumn(username);

            PrivilegeOnTable_DataGrid.ItemsSource = privilegeOnTables;
            PrivilegeOnColumn_DataGrid.ItemsSource = privilegeOnColumns;


        }
    }
}
