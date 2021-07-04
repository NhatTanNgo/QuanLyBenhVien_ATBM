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

namespace HeThongBenhVien.Reception
{
    /// <summary>
    /// Interaction logic for GUI_ReceptionWindow.xaml
    /// </summary>
    public partial class GUI_ReceptionWindow : Window
    {
        private int tabSelection = 0;
        private String username = "NULL";
        private GUI_AddProfile addProfilePage = new GUI_AddProfile();
        private GUI_ManageProfile manageProfile = new GUI_ManageProfile();

        public GUI_ReceptionWindow()
        {
            InitializeComponent();
        }

        private void AddProfileButton_Click(object sender, RoutedEventArgs e)
        {
            if(tabSelection == 0)
            {
                return;
            }    

            tabSelection = 0;
            AddProfileButton.Background = Brushes.White;
            ManageProfileButton.Background = Brushes.LightGray;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(addProfilePage);
        }

        private void ManageProfileButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 1)
            {
                return;
            }

            tabSelection = 1;
            AddProfileButton.Background = Brushes.LightGray;
            ManageProfileButton.Background = Brushes.White;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(manageProfile);
        }

        private void OtherButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 2)
            {
                return;
            }

            tabSelection = 2;
            AddProfileButton.Background = Brushes.LightGray;
            ManageProfileButton.Background = Brushes.LightGray;
            OtherButton.Background = Brushes.White;
            //MainFrame.Navigate(addProfilePage);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tabSelection = 0;
            AddProfileButton.Background = Brushes.White;
            ManageProfileButton.Background = Brushes.LightGray;
            OtherButton.Background = Brushes.LightGray;
            MainFrame.Navigate(addProfilePage);
            LoginUsernameTextBlock.Text = "Hello " + username.ToUpper();
        }
    }
}
