using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for EditAccountForm.xaml
    /// </summary>
    public partial class EditAccountForm : Window
    {
        public EditAccountForm()
        {
            InitializeComponent();
            
            notify.Visibility = Visibility.Hidden;
        }

      
        private void btnBackEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditEmployeeID.Text == "" || tbxEditEmployeeName.Text == ""
                || tbxEditEmployeePhoneNumber.Text == "" || dpkEditWorkingDate.Text == ""
                || tbxEditUsername.Text == "" || tbxEditPassword.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
        }

        private void tbxEditEmployeePhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void editAvatarBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png";

            if (openFile.ShowDialog() == true)
            {
                editavatar.ImageSource = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void cbbEditAccountPriority_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void cbbEditAccountPriority_DropDownClosed(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEmployeeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEmployeeName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEmployeePhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void dpkEditWorkingDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }
    }
}
