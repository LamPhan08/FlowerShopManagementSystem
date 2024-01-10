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
    /// Interaction logic for AddSupplierForm.xaml
    /// </summary>
    public partial class AddSupplierForm : Window
    {
        SuppliersView suppliersView;
        //string finalAddress;
        private ISupplierStrategy _strategy;
        public AddSupplierForm()
        {
            InitializeComponent();
            _strategy = new DefaultSupplierStrategy();
            notify.Visibility = Visibility.Hidden;
        }

        public void SetStrategy(ISupplierStrategy strategy)
        {
            _strategy = strategy;
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (tbxSupplierID.Text == "" || tbxSupplierName.Text == ""
                || tbxSupplierPhoneNumber.Text == "" || tbxSupplierStreet.Text == ""
                || cbbSupplierWard.Text == "" || cbbSupplierDistrict.Text == "" || cbbSupplierCity.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                AddSupplier();
            }
        }

        private void btnBackAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbxSupplierPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbbSupplierWard_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void cbbSupplierDistrict_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void cbbSupplierCity_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxSupplierID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxSupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxSupplierPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxSupplierStreet_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void AddSupplier()
        {
            SetStrategy(new AddSupplierStrategy(this));
            _strategy.Execute(new Supplier());
        }
    }
}
