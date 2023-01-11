using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for AddSupplierForm.xaml
    /// </summary>
    public partial class AddSupplierForm : Window
    {
        SuppliersView suppliersView;
        string finalAddress;
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
            try
            {
                suppliersView = new SuppliersView();
                Supplier supplier = new Supplier();
                supplier.maNCC = tbxSupplierID.Text.ToString();
                supplier.tenNCC = tbxSupplierName.Text.ToString();
                ComboBoxItem wardCBI = (ComboBoxItem)cbbSupplierWard.SelectedItem,
                            districtCBI = (ComboBoxItem)cbbSupplierDistrict.SelectedItem,
                            cityCBI = (ComboBoxItem)cbbSupplierCity.SelectedItem;
                string street = tbxSupplierStreet.Text.ToString();
                string ward = wardCBI.Content.ToString(),
                        district = districtCBI.Content.ToString(),
                        city = cityCBI.Content.ToString();
                supplier.diaChiNCC = street + ", " + ward + ", " + district + ", " + city;
                finalAddress = supplier.diaChiNCC;
                supplier.soDTNCC = tbxSupplierPhoneNumber.Text.ToString();
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into NHA_CUNG_CAP(MANCC, TENNCC, DIACHI, SODT) " +
                    "values ('" + supplier.maNCC + "', '" + supplier.tenNCC + "', '" + supplier.diaChiNCC + "', '" + supplier.soDTNCC + "')"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch (Exception)
            {
                if(tbxSupplierID.Text.Length < 6 || tbxSupplierID.Text.Length > 6)
                {
                    MessageBox.Show("Error:\nSupplier's ID must not have more/less than 6 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxSupplierName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nSupplier's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(finalAddress.Length > 50)
                {
                    MessageBox.Show("Error:\nSupplier's address must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxSupplierPhoneNumber.Text.Length < 10 || tbxSupplierPhoneNumber.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nSupplier's phone number must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
