using BUS;
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

namespace PhanHe01.UserPages
{
    /// <summary>
    /// Interaction logic for AddRolePage.xaml
    /// </summary>
    public partial class AddRolePage : Page
    {
        public AddRolePage()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            String rolename = RolenameTextBox.Text.ToUpper();
            String password = PasswordTextBox.Text.ToUpper();
           

            if(rolename.Trim().Equals(""))
            {
                MessageBox.Show("Role Require!");
                return;
            }

            try
            {
                BUS_Role.Instance.CreateRole(rolename, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{rolename} created successfully!");
        }
    }
}
