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
    internal class EditSupplierStrategy : ISupplierStrategy
    {
        EditSupplierForm _form;
        SuppliersView suppliersView;
        string finalEditedAddress;
        public EditSupplierStrategy(EditSupplierForm form)
        {
            _form = form;
        }
        public void Execute(Supplier supplierNewInfo)
        {
            try
            {
                supplierNewInfo = new Supplier();
                supplierNewInfo.maNCC = _form.tbxEditSupplierID.Text.ToString();
                supplierNewInfo.tenNCC = _form.tbxEditSupplierName.Text.ToString();
                ComboBoxItem newWardCBI = (ComboBoxItem)_form.cbbEditSupplierWard.SelectedItem,
                            newDistrictCBI = (ComboBoxItem)_form.cbbEditSupplierDistrict.SelectedItem,
                            newCityCBI = (ComboBoxItem)_form.cbbEditSuppierCity.SelectedItem;
                string newWard = newWardCBI.Content.ToString(),
                        newDistrict = newDistrictCBI.Content.ToString(),
                        newCity = newCityCBI.Content.ToString();
                supplierNewInfo.diaChiNCC = _form.tbxEditSupplierStreet.Text.ToString() + ", " + newWard + ", " + newDistrict + ", " + newCity;
                finalEditedAddress = supplierNewInfo.diaChiNCC;
                supplierNewInfo.soDTNCC = _form.tbxEditSupplierPhoneNumber.Text.ToString();
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand(
                    "update NHA_CUNG_CAP " +
                    "set TENNCC = '" + supplierNewInfo.tenNCC + "', DIACHI = '" + supplierNewInfo.diaChiNCC + "', SODT = '" + supplierNewInfo.soDTNCC + "' " +
                    "where MANCC = '" + supplierNewInfo.maNCC + "'"))
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
                if (_form.tbxEditSupplierID.Text.Length < 6 || _form.tbxEditSupplierID.Text.Length > 6)
                {
                    MessageBox.Show("Error:\nSupplier's ID must not have more/less than 6 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (_form.tbxEditSupplierName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nSupplier's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (finalEditedAddress.Length > 50)
                {
                    MessageBox.Show("Error:\nSupplier's address must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (_form.tbxEditSupplierPhoneNumber.Text.Length < 10 || _form.tbxEditSupplierPhoneNumber.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nSupplier's phone number must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
