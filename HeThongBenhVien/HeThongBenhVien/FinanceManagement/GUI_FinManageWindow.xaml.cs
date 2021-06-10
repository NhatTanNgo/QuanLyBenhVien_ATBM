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
using System.Windows.Shapes;

namespace HeThongBenhVien.FinanceManagement
{
    /// <summary>
    /// Interaction logic for GUI_FinManageWindow.xaml
    /// </summary>
    public partial class GUI_FinManageWindow : Window
    {
        private int tabSelection = 0;
        private String username = "NULL";
        private GUI_FinStaffsPage finStaffsPage = new GUI_FinStaffsPage();
        private GUI_ServicePage servicePage = new GUI_ServicePage();

        public GUI_FinManageWindow()
        {
            InitializeComponent();
        }

        public GUI_FinManageWindow(String _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void OtherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageFinStaffButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 0)
            {
                return;
            }

            tabSelection = 0;
            ManageServiceButton.Background = Brushes.LightGray;
            ManageFinStaffButton.Background = Brushes.White;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(finStaffsPage);
        }

        private void ManageServiceButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 1)
            {
                return;
            }

            tabSelection = 1;
            ManageServiceButton.Background = Brushes.White;
            ManageFinStaffButton.Background = Brushes.LightGray;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(servicePage);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tabSelection = 0;
            ManageServiceButton.Background = Brushes.LightGray;
            ManageFinStaffButton.Background = Brushes.White;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(finStaffsPage);
            LoginUsernameTextBlock.Text = "Hello " + username.ToUpper();
        }
    }
}
