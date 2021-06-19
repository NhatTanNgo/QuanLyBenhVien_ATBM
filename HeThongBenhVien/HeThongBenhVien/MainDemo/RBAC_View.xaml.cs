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

namespace HeThongBenhVien.MainDemo
{
    /// <summary>
    /// Interaction logic for RBAC_View.xaml
    /// </summary>
    public partial class RBAC_View : Page
    {
        private FinanceManagement.GUI_FinManageWindow finManageWindow = null;
        private PharmacySeller.GUI_PharmaSellerWindow sellerWindow = null;
        private String username = "NULL";

        public RBAC_View()
        {
            InitializeComponent();
        }

        public RBAC_View(String _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void seller_btn_Click(object sender, RoutedEventArgs e)
        {
            if(sellerWindow == null)
            {
                sellerWindow = new PharmacySeller.GUI_PharmaSellerWindow();
            }

            sellerWindow.Show();
        }

        private void finManage_btn_Click(object sender, RoutedEventArgs e)
        {
            if(finManageWindow == null)
            {
                finManageWindow = new FinanceManagement.GUI_FinManageWindow(username);
            }

            finManageWindow.Show();
        }
    }
}
