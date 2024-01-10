using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace FlowerShopManagementSystem.Suppliers.StrategyForSupplier_CRUD
{
    public class AddSupplierStrategy : ISupplierStrategy
    {
        AddSupplierForm _form;
        SuppliersView suppliersView;
        string finalAddress;
        public AddSupplierStrategy(AddSupplierForm form)
        {
            _form = form;
        }
        public void Execute(Supplier supplier)
        {
            try
            {
                suppliersView = new SuppliersView();
                supplier.maNCC = _form.tbxSupplierID.Text.ToString();
                supplier.tenNCC = _form.tbxSupplierName.Text.ToString();
                ComboBoxItem wardCBI = (ComboBoxItem)_form.cbbSupplierWard.SelectedItem,
                            districtCBI = (ComboBoxItem)_form.cbbSupplierDistrict.SelectedItem,
                            cityCBI = (ComboBoxItem)_form.cbbSupplierCity.SelectedItem;
                string street = _form.tbxSupplierStreet.Text.ToString();
                string ward = wardCBI.Content.ToString(),
                        district = districtCBI.Content.ToString(),
                        city = cityCBI.Content.ToString();
                supplier.diaChiNCC = street + ", " + ward + ", " + district + ", " + city;
                finalAddress = supplier.diaChiNCC;
                supplier.soDTNCC = _form.tbxSupplierPhoneNumber.Text.ToString();
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
                _form.Close();
            }
            catch (Exception)
            {
                if (_form.tbxSupplierID.Text.Length < 6 || _form.tbxSupplierID.Text.Length > 6)
                {
                    MessageBox.Show("Error:\nSupplier's ID must not have more/less than 6 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (_form.tbxSupplierName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nSupplier's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (finalAddress.Length > 50)
                {
                    MessageBox.Show("Error:\nSupplier's address must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (_form.tbxSupplierPhoneNumber.Text.Length < 10 || _form.tbxSupplierPhoneNumber.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nSupplier's phone number must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
