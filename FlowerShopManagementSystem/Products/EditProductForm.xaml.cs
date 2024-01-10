using FlowerShopManagementSystem.Products.ProductMementor;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Products
{
    /// <summary>
    /// Interaction logic for EditProductForm.xaml
    /// </summary>
    public partial class EditProductForm : Window
    {
        string imageToEdit, imageName;
        Product newProductInfo;

        public EditProductForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;

        }


        private void btnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            if (tbxProductID.Text == "" || tbxEditProductName.Text == ""
                || tbxEditProductType.Text == "" || cbbEditSuppier.Text == ""
                || tbxEditEvent.Text == "" || tbxEditProductPrice.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                UpdateProduct();
            }
        }

        private void btnBackEditProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbxEditProductPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void editProductImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.*)|*.*";
            openFile.FileName = "hoa_cuc.jpg";

            if (openFile.ShowDialog() == true)
            {
                imageToEdit = openFile.FileName;
                editProductImage.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void cbbEditSuppier_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxProductID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditProductType_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEvent_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditProductPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void UpdateProduct()
        {
            try
            {
                newProductInfo = new Product();
                newProductInfo.productCode = tbxProductID.Text.ToString();
                newProductInfo.productName = tbxEditProductName.Text.ToString();
                newProductInfo.productType = tbxEditProductType.Text.ToString();
                newProductInfo.productOccasion = tbxEditEvent.Text.ToString();
                ComboBoxItem productSupplierCBI = (ComboBoxItem)cbbEditSuppier.SelectedItem;
                string supplierName = productSupplierCBI.Content.ToString();
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database result = new Database("RESULT", "select MANCC from NHA_CUNG_CAP where TENNCC = '" + supplierName + "'");
                newProductInfo.productSupplier = result.Rows[0][0].ToString();
                newProductInfo.productPrice = double.Parse(tbxEditProductPrice.Text.ToString());
                if (imageToEdit != "")
                {
                    imageName = System.IO.Path.GetFileName(imageToEdit);
                    newProductInfo.productImage = imageName;
                    if (!System.IO.File.Exists("../../Products/Product Image/" + imageName))
                    {
                        System.IO.File.Copy(imageToEdit, "../../Products/Product Image/" + imageName);
                    }
                }
                if (newProductInfo.productImage != ProductsView.selectedProduct.productImage)
                {
                    using (var sqlConnection = new SqlConnection(Database.connection))
                    using (var cmd = new SqlDataAdapter())
                    using (var insertCommand = new SqlCommand(
                        "update SAN_PHAM " +
                        "set TENSP = '" + newProductInfo.productName + "', LOAISP = '" + newProductInfo.productType + "', SU_KIEN = '" + newProductInfo.productOccasion.ToLower() + "', MANCC = '" + newProductInfo.productSupplier + "', GIA = '" + newProductInfo.productPrice + "', HINH_ANH = '" + newProductInfo.productImage + "' " +
                        "where MASP = '" + newProductInfo.productCode + "'"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    using (var sqlConnection = new SqlConnection(Database.connection))
                    using (var cmd = new SqlDataAdapter())
                    using (var insertCommand = new SqlCommand(
                        "update SAN_PHAM " +
                        "set TENSP = '" + newProductInfo.productName + "', LOAISP = '" + newProductInfo.productType + "', SU_KIEN = '" + newProductInfo.productOccasion.ToLower() + "', MANCC = '" + newProductInfo.productSupplier + "', GIA = '" + newProductInfo.productPrice + "' " +
                        "where MASP = '" + newProductInfo.productCode + "'"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
            }
            catch (Exception)
            {
                if (imageName.Length > 100)
                {
                    MessageBox.Show("Error:\nImage's name must not have more than 100 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxProductID.Text.Length > 5 || tbxProductID.Text.Length < 5)
                {
                    MessageBox.Show("Error:\nProduct's ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditProductName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nProduct's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditProductType.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nProduct's type must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditEvent.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nThe event must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
