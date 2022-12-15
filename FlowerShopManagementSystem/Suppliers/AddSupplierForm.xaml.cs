﻿using System;
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
    /// Interaction logic for AddSupplierForm.xaml
    /// </summary>
    public partial class AddSupplierForm : Window
    {
        public AddSupplierForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (tbxSupplierID.Text == "" || tbxSupplierName.Text == ""
                || tbxSupplierPhoneNumber.Text == "" || tbxSupplierStreet.Text == ""
                || cbbSupplierWard.Text == "" || cbbSupplierDistrict.Text == "" || cbbSupplierCity.Text == "")
            {
                notify.Visibility = Visibility.Visible;
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
    }
}
