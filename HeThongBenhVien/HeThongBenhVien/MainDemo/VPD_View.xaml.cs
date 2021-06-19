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
    /// Interaction logic for VPD_View.xaml
    /// </summary>
    public partial class VPD_View : Page
    {
        private VPD_MedicalRecord medicalRecordPage = null; 
        public VPD_View()
        {
            InitializeComponent();
        }

        private void TimeKeepButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MedicalRecordButton_Click(object sender, RoutedEventArgs e)
        {
            if (medicalRecordPage == null)
            {
                medicalRecordPage = new VPD_MedicalRecord();
            }
            subFrame.Navigate(medicalRecordPage);
        }
    }
}
