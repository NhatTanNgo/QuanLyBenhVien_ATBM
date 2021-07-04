using BUS;
using DTO;
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
    /// Interaction logic for DAC_ServiceView.xaml
    /// </summary>
    public partial class DAC_ServiceView : Page
    {
        public DAC_Service servicePage = null;
        public DAC_Drugs drugsPage = null;
        public DAC_ServiceView()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            if (servicePage == null)
            {
                servicePage = new DAC_Service();
            }
            subFrame.Navigate(servicePage);
        }

        private void SelectDrugsButton_Click(object sender, RoutedEventArgs e)
        {
            if (drugsPage == null)
            {
                drugsPage = new DAC_Drugs();
            }
            subFrame.Navigate(drugsPage);
        }
    }
}
