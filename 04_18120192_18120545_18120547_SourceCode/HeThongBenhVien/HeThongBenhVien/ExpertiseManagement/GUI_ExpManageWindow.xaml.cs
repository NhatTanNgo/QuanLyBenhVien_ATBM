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

namespace HeThongBenhVien.ExpertiseManagement
{
    /// <summary>
    /// Interaction logic for GUI_ExpManageWindow.xaml
    /// </summary>
    public partial class GUI_ExpManageWindow : Window
    {
        private int tabSelection = 0;
        private String username = "NULL";
        private GUI_ExpertisePage expertisePage = new GUI_ExpertisePage();

        public GUI_ExpManageWindow()
        {
            InitializeComponent();
        }

        public GUI_ExpManageWindow(String _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tabSelection = 0;
            ManageExpertiseButton.Background = Brushes.White;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(expertisePage);
            LoginUsernameTextBlock.Text = "Hello " + username.ToUpper();
        }

        private void ManageExpertiseButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 0)
            {
                return;
            }

            tabSelection = 0;
            ManageExpertiseButton.Background = Brushes.White;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(expertisePage);
        }

        private void OtherButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 1)
            {
                return;
            }

            tabSelection = 1;
            ManageExpertiseButton.Background = Brushes.LightGray;
            OtherButton.Background = Brushes.White;
        }
    }
}
