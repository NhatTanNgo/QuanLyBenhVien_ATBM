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
using System.Windows.Shapes;

namespace PhanHe01.PrivilegePages
{
    /// <summary>
    /// Interaction logic for PrivsColumnWindow.xaml
    /// </summary>
    public partial class PrivsColumnWindow : Window
    {
        private DTO_PrivilegeOnTable privilegeOnTable;
        private GrantPrivilegePage page;
        private String username;
        private ObservableCollection<DTO_PrivilegeOnColumn> list;

        public PrivsColumnWindow(GrantPrivilegePage page, DTO_PrivilegeOnTable privsTable, String username)
        {
            this.privilegeOnTable = privsTable;
            this.page = page;
            this.username = username;
            InitializeComponent();

            list = BUS_Privilege.Instance.GetPrivilegesAllColumns(username, privilegeOnTable.TableName);

            if(list.Count == 0)
            {
                page.OpenSubWindow = false;
                return;
            }
            page.OpenSubWindow = true;
            PrivSColumnDataGrid.ItemsSource = list;

        } 

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

       

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            page.GetPrivilegesFromColumn(list);
            this.Close();
        }
    }
}
