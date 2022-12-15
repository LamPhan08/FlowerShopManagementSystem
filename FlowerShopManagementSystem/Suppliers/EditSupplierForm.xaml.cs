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

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for EditSupplierForm.xaml
    /// </summary>
    public partial class EditSupplierForm : Window
    {
        public EditSupplierForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;

        }

        private void btnEditSaveSuppier_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditSupplierID.Text == "" || tbxEditSupplierName.Text == ""
                || tbxEditSupplierPhoneNumber.Text == "" || tbxEditSupplierStreet.Text == ""
                || cbbEditSupplierWard.Text == "" || cbbEditSupplierDistrict.Text == "" || cbbEditSuppierCity.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
        }

        private void btnEditBackSupplier_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbbEditSupplierWard_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void cbbEditSupplierDistrict_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void cbbEditSuppierCity_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditSupplierPhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbxEditSupplierID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditSupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditSupplierPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditSupplierStreet_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }
    }
}
