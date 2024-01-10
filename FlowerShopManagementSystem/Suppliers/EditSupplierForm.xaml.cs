using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FlowerShopManagementSystem.Suppliers.StrategyForSupplier_CRUD;

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for EditSupplierForm.xaml
    /// </summary>
    public partial class EditSupplierForm : Window
    {
        Supplier supplierNewInfo;
        //string finalEditedAddress;
        private ISupplierStrategy _strategy;

        public EditSupplierForm()
        {
            InitializeComponent();
            _strategy = new DefaultSupplierStrategy();
            notify.Visibility = Visibility.Hidden;

        }

        public void SetStrategy(ISupplierStrategy strategy)
        {
            _strategy = strategy;
        }

        private void btnEditSaveSuppier_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditSupplierID.Text == "" || tbxEditSupplierName.Text == ""
                || tbxEditSupplierPhoneNumber.Text == "" || tbxEditSupplierStreet.Text == ""
                || cbbEditSupplierWard.Text == "" || cbbEditSupplierDistrict.Text == "" || cbbEditSuppierCity.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                UpdateSupplier();
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

        private void UpdateSupplier()
        {
            SetStrategy(new EditSupplierStrategy(this));
            _strategy.Execute(supplierNewInfo);
        }
    }
}
