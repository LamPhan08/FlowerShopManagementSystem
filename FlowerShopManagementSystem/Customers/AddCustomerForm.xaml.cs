using FlowerShopManagementSystem.Customers.CustomerBuilder;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlowerShopManagementSystem.Customers
{
    /// <summary>
    /// Interaction logic for AddCustomerForm.xaml
    /// </summary>
    public partial class AddCustomerForm : Window
    {
        NewCustomerBuilder builder;
        CustomersView customersView;
        string finalAddress;
        public AddCustomerForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;
        }

        private void btnBackCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (tbxCustomerName.Text == "" || tbxCustomerPhone.Text == ""
                || tbxCustomerHouseNumber.Text == "" || tbxCustomerStreet.Text == ""
                || cbbDistrict.Text == "" || cbbCity.Text == "" || cbbProvince.Text == ""
                || dpkRegistrationDate.Text == "")
            {
                notify.Visibility = Visibility.Visible;

            }
            else
            {
                notify.Visibility = Visibility.Collapsed;
                ComboBoxItem districtCBI = (ComboBoxItem)cbbDistrict.SelectedItem,
                            cityCBI = (ComboBoxItem)cbbCity.SelectedItem,
                            provinceCBI = (ComboBoxItem)cbbProvince.SelectedItem;
                string district = districtCBI.Content.ToString(),
                        city = cityCBI.Content.ToString(),
                        province = provinceCBI.Content.ToString();
                if (province == "(Empty)")
                {
                    finalAddress = tbxCustomerHouseNumber.Text.ToString() + ", " + tbxCustomerStreet.Text.ToString() + ", " + district + ", " + city;
                }
                else
                {
                    finalAddress = tbxCustomerHouseNumber.Text.ToString() + ", " + tbxCustomerStreet.Text.ToString() + ", " + district + ", " + city + ", " + province;
                }
                builder = new NewCustomerConcreteBuilder();
                builder.setName(tbxCustomerName.Text.ToString())
                    .setAddress(finalAddress)
                    .setPhone(tbxCustomerPhone.Text.ToString())
                    .setNgayDK(dpkRegistrationDate.Text.ToString())
                    .setDoanhSo("0");
                AddCustomer(builder.build());
            }
        }

        private void tbxCustomerSales_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbxCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbbDistrict_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }


        private void cbbCity_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void cbbProvince_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxCustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxCustomerPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxCustomerHouseNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxCustomerStreet_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void tbxCustomerSales_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void dpkRegistrationDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void AddCustomer(NewCustomer customer)
        {
            try
            {
                customersView = new CustomersView();

                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into KHACH_HANG (SODT_KH, HOTEN, DIACHI, NGDK, DOANHSO) " +
                    "values ('" + customer.phone + "', '" + customer.name + "', '" + customer.address + "', '" + DateTime.Parse(customer.ngayDK) + "', 0)"))
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
                if (tbxCustomerName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nCustomer's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (finalAddress.Length > 50)
                {
                    MessageBox.Show("Error:\nCustomer's address must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
