using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.Suppliers.StrategyForSupplier_CRUD
{
    public class ReadSupplierStrategy : ISupplierStrategy
    {
        public ReadSupplierStrategy()
        {

        }

        public void Execute(Supplier selectedSupplier)
        {
            try
            {
                ViewSupplierDetails viewSupplierDetails = new ViewSupplierDetails();
                //selectedSupplier = (Supplier)_suppliersView.suppliersDataGrid.SelectedItem as Supplier;
                string supplierID = selectedSupplier.maNCC.Trim(),
                    supplierName = selectedSupplier.tenNCC.Trim(),
                    supplierAddress = selectedSupplier.diaChiNCC.ToString();
                string[] addressParts = supplierAddress.Split(',');
                string street = addressParts[0].Trim(),
                    ward = addressParts[1].Trim(),
                    district = addressParts[2].Trim(),
                    city = addressParts[3].Trim();
                string phoneNumber = selectedSupplier.soDTNCC.Trim();
                viewSupplierDetails.txtblckSupplierID.Text = supplierID;
                viewSupplierDetails.txtblckSupplierName.Text = supplierName;
                viewSupplierDetails.txtblckSupplierPhoneNumber.Text = phoneNumber;
                viewSupplierDetails.txtblckSupplierStreet.Text = street;
                viewSupplierDetails.txtblckSupplierWard.Text = ward;
                viewSupplierDetails.txtblckSupplierDistrict.Text = district;
                viewSupplierDetails.txtblckSupplierCity.Text = city;
                viewSupplierDetails.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
