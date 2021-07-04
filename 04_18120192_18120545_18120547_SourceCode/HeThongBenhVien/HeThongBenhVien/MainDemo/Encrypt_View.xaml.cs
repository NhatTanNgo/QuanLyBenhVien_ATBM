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
    /// Interaction logic for Encrypt_View.xaml
    /// </summary>
    public partial class Encrypt_View : Page
    {
        public Encrypt_View()
        {
            InitializeComponent();
        }

        private Encrypt_InsertMedicalRecord insertPage = null;
        private VPD_MedicalRecord selectPage = null;

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            if(insertPage == null)
            {
                insertPage = new Encrypt_InsertMedicalRecord();
            }
            subFrame.Navigate(insertPage);
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            if(selectPage == null)
            {
                selectPage = new VPD_MedicalRecord();
            }
            subFrame.Navigate(selectPage);
        }
    }
}
