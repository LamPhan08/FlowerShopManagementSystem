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

namespace FlowerShopManagementSystem.Customers
{
    /// <summary>
    /// Interaction logic for EditCustomerForm.xaml
    /// </summary>
    public partial class EditCustomerForm : Window
    {
        public EditCustomerForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;

        }

        private void btnEditBackCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditCustomerName.Text == "" || tbxEditCustomerPhone.Text == ""
                || tbxEditCustomerHouseNumber.Text == "" || tbxEditCustomerStreet.Text == ""
                || cbbEditDistrict.Text == "" || cbbEditCity.Text == "" || cbbEditProvince.Text == ""
                || tbxEditCustomerSales.Text == "" || dpkEditRegistrationDate.Text == "")
            {
                notify.Visibility = Visibility.Visible;

            }
        }

        private void tbxEditCustomerSales_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbxEditCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbbEditDistrict_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void cbbEditCity_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }


        private void cbbEditProvince_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void cbbEditDistrict_DropDownOpened_1(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxEditCustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxEditCustomerPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxEditCustomerHouseNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxEditCustomerStreet_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxEditCustomerSales_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void dpkEditRegistrationDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }
    }
}
