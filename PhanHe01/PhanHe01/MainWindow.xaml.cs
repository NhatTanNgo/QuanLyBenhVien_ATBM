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

namespace PhanHe01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int tabSelection = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageUserButton_Click(object sender, RoutedEventArgs e)
        {
            if(tabSelection == 0)
            {
                return;
            }

            tabSelection = 0;
            ManagePrivilege.Background = Brushes.Gray;
            ManageUserButton.Background = Brushes.White;
        }

        private void ManagePrivilege_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 1)
            {
                return;
            }

            tabSelection = 1;
            ManagePrivilege.Background = Brushes.White;
            ManageUserButton.Background = Brushes.Gray;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tabSelection = 0;
            ManagePrivilege.Background = Brushes.Gray;
            ManageUserButton.Background = Brushes.White;
        }
    }
}
