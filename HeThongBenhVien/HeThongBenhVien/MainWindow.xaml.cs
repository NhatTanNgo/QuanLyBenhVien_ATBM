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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace HeThongBenhVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String _username = "NULL";
        int tabSelection = -1;

        private MainDemo.DAC_ServiceView dacPage = null;
        private MainDemo.RBAC_View rbacPage = null;
        private MainDemo.VPD_View vpdPage = null;
        private MainDemo.Encrypt_View encryptPage = null;
        public MainWindow(String username)
        {
            InitializeComponent();
            _username = username;
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginUsernameTextBlock.Text = "Hello " + _username;
            DACButton.Background = Brushes.LightGray;
            RBACButton.Background = Brushes.LightGray;
            VPDButton.Background = Brushes.LightGray;
            EncrytionButton.Background = Brushes.LightGray;
            OLSButton.Background = Brushes.LightGray;
        }

        
        private void OLSButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 4)
            {
                return;
            }

            tabSelection = 4;
            DACButton.Background = Brushes.LightGray;
            RBACButton.Background = Brushes.LightGray;
            VPDButton.Background = Brushes.LightGray;
            EncrytionButton.Background = Brushes.LightGray;
            OLSButton.Background = Brushes.White;
            //MainFrame.Navigate(null);
        }

        private void EncryptionButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 3)
            {
                return;
            }

            tabSelection = 3;
            DACButton.Background = Brushes.LightGray;
            RBACButton.Background = Brushes.LightGray;
            VPDButton.Background = Brushes.LightGray;
            EncrytionButton.Background = Brushes.White;
            OLSButton.Background = Brushes.LightGray;

            if(encryptPage == null)
            {
                encryptPage = new MainDemo.Encrypt_View();
            }
            MainFrame.Navigate(encryptPage);
        }

        private void VPDButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 2)
            {
                return;
            }

            tabSelection = 2;
            DACButton.Background = Brushes.LightGray;
            RBACButton.Background = Brushes.LightGray;
            VPDButton.Background = Brushes.White;
            EncrytionButton.Background = Brushes.LightGray;
            OLSButton.Background = Brushes.LightGray;
            
            if(vpdPage == null)
            {
                vpdPage = new MainDemo.VPD_View();
            }    
            MainFrame.Navigate(vpdPage);
        }

        private void RBACButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 1)
            {
                return;
            }

            tabSelection = 1;
            DACButton.Background = Brushes.LightGray;
            RBACButton.Background = Brushes.White;
            VPDButton.Background = Brushes.LightGray;
            EncrytionButton.Background = Brushes.LightGray;
            OLSButton.Background = Brushes.LightGray;

            if(rbacPage == null)
            {
                rbacPage = new MainDemo.RBAC_View(_username);
            }
            MainFrame.Navigate(rbacPage);
        }

        private void DACButton_Click(object sender, RoutedEventArgs e)
        {
            if (tabSelection == 0)
            {
                return;
            }

            tabSelection = 0;
            DACButton.Background = Brushes.White;
            RBACButton.Background = Brushes.LightGray;
            VPDButton.Background = Brushes.LightGray;
            EncrytionButton.Background = Brushes.LightGray;
            OLSButton.Background = Brushes.LightGray;

            if(dacPage == null)
            {
                dacPage = new MainDemo.DAC_ServiceView();
            } 
                
            MainFrame.Navigate(dacPage);
        }
    }
}
