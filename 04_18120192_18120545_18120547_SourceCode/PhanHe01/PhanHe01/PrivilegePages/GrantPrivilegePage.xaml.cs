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
        private List<ObservableCollection<DTO_PrivilegeOnColumn>> privilegeOnColumns = null;

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool checkExistUser = BUS_User.Instance.CheckUser(UsernameTextBox.Text);
                if (!checkExistUser)
                {
                    bool checkExistRole = BUS_Role.Instance.CheckRole(UsernameTextBox.Text);
                    if (!checkExistRole)
                    {
                        MessageBox.Show("KHÔNG TÌM THẤY USER/ROLE NÀY!", "Oops");
                        return;
                    }
                }
                PrivilegeTableStackPanel.Visibility = Visibility;
                privilegesOnTableList = BUS_Privilege.Instance.GetPrivilegesAllTables(UsernameTextBox.Text);
                PrivilegeOnTable_DataGrid.ItemsSource = privilegesOnTableList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BUS_Privilege.Instance.ExecPrivilegeOnTable(privilegesOnTableList, UsernameTextBox.Text);
                BUS_Privilege.Instance.ExecPrivilegeOnColumn(privilegeOnColumns, UsernameTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrivilegeColumnButton_Click(object sender, RoutedEventArgs e)
        {
            DTO_PrivilegeOnTable selectedRow = PrivilegeOnTable_DataGrid.SelectedItem as DTO_PrivilegeOnTable;
            if(selectedRow == null) {
                return;
            }
            PrivsColumnWindow privsColumnWindow = new PrivsColumnWindow(this, selectedRow, UsernameTextBox.Text);
            if(OpenSubWindow)
            {
                privsColumnWindow.Show();
               
            }
            else
            {
                MessageBox.Show("No privleges on columns detected!");
                privsColumnWindow.Close();
            }
            privilegeOnColumns = new List<ObservableCollection<DTO_PrivilegeOnColumn>>(); ;

        }

        public void GetPrivilegesFromColumn(ObservableCollection<DTO_PrivilegeOnColumn> list)
        {
            privilegeOnColumns.Add(list);
        }

        public bool OpenSubWindow { get; set; }
    }
}
