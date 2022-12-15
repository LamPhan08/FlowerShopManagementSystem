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
    /// Interaction logic for AddAccountForm.xaml
    /// </summary>
    public partial class AddAccountForm : Window
    {
        public AddAccountForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;
        }

        private void btnBackEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEmployeeID.Text == "" || tbxEmployeeName.Text == ""
                || tbxEmployeePhoneNumber.Text == "" || dpkWorkingDate.Text == ""
                || tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
        }

        private void uploadAvatarBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png";

            if (openFile.ShowDialog() == true)
            {
                avatar.ImageSource = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void tbxEmployeePhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbbAccountPriority_DropDownOpened(object sender, EventArgs e)
        {
            //cbbAccountPriority.Background = Brushes.LightGray;
            notify.Visibility = Visibility.Hidden;

        }


        private void tbxEmployeeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEmployeeName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEmployeePhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void dpkWorkingDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void dpkWorkingDate_GotFocus(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }
    }
}
