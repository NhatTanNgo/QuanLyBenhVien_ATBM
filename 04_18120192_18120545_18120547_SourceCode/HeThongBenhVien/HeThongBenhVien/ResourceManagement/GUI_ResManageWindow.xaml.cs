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

namespace HeThongBenhVien.ResourceManagement
{
    /// <summary>
    /// Interaction logic for GUI_ResManageWindow.xaml
    /// </summary>
    public partial class GUI_ResManageWindow : Window
    {
        private int tabSelection = 0;
        private String username = "NULL";
        private GUI_RoomPage roomPage = new GUI_RoomPage();
        private GUI_HumanPage humanPage = new GUI_HumanPage();
        private GUI_SchedulePage schedulePage = new GUI_SchedulePage();

        public GUI_ResManageWindow(String loginUsername)
        {
            InitializeComponent();
            username = loginUsername;
        }

        public GUI_ResManageWindow()
        {
            InitializeComponent();
        }

        private void ManageRoomButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 0)
            {
                return;
            }

            tabSelection = 0;
            ManageHumanButton.Background = Brushes.LightGray;
            ManageScheduleButton.Background = Brushes.LightGray;
            ManageRoomButton.Background = Brushes.White;
            MainFrame.Navigate(roomPage);
        }

        private void ManageHumanButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 1)
            {
                return;
            }

            tabSelection = 1;
            ManageHumanButton.Background = Brushes.White;
            ManageScheduleButton.Background = Brushes.LightGray;
            ManageRoomButton.Background = Brushes.LightGray;
            MainFrame.Navigate(humanPage);
        }

        private void ManageScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 2)
            {
                return;
            }

            tabSelection = 2;
            ManageHumanButton.Background = Brushes.LightGray;
            ManageScheduleButton.Background = Brushes.White;
            ManageRoomButton.Background = Brushes.LightGray;
            MainFrame.Navigate(schedulePage);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tabSelection = 0;
            ManageHumanButton.Background = Brushes.LightGray;
            ManageScheduleButton.Background = Brushes.LightGray;
            ManageRoomButton.Background = Brushes.White;
            LoginUsernameTextBlock.Text = "Hello " + username.ToUpper();
            MainFrame.Navigate(roomPage);
        }
    }
}
