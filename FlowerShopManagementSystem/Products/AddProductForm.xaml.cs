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
    /// Interaction logic for AddProductForm.xaml
    /// </summary>
    public partial class AddProductForm : Window
    {
        string image, imageName;
        ProductsView productsView;

        public AddProductForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;
        }

        private void tbxProductPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (tbxProductID.Text == "" || tbxProductName.Text == ""
                || tbxProductType.Text == "" || cbbSuppier.Text == ""
                || tbxEvent.Text == "" || tbxProductPrice.Text == "") {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                AddProduct();
            }
        }

        private void btnBackAddProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void uploadProductImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.*)|*.*";
            openFile.FileName = "";

            if (openFile.ShowDialog() == true)
            {
                image = openFile.FileName;
                productImage.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void cbbSuppier_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxProductID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxProductType_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEvent_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxProductPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void AddProduct()
        {
            try
            {
                productsView = new ProductsView();
                Product product = new Product();
                product.productCode = tbxProductID.Text.ToString();
                product.productName = tbxProductName.Text.ToString();
                product.productType = tbxProductType.Text.ToString();
                product.productOccasion = tbxEvent.Text.ToString();
                ComboBoxItem productSupplierCBI = (ComboBoxItem)cbbSuppier.SelectedItem;
                string supplierName = productSupplierCBI.Content.ToString();
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database result = new Database("RESULT", "select MANCC from NHA_CUNG_CAP where TENNCC = '" + supplierName + "'");
                product.productSupplier = result.Rows[0][0].ToString();
                product.productPrice = double.Parse(tbxProductPrice.Text.ToString());
                if (image != "")
                {
                    imageName = System.IO.Path.GetFileName(image);
                    product.productImage = imageName;
                    if (!System.IO.File.Exists("../../Products/Product Image/" + imageName))
                    {
                        System.IO.File.Copy(image, "../../Products/Product Image/" + imageName);
                    }
                }
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into SAN_PHAM(MASP, TENSP, LOAISP, SU_KIEN, MANCC, GIA, HINH_ANH) " +
                    "values ('" + product.productCode + "','" + product.productName + "','" + product.productType + "','" + product.productOccasion.ToLower() + "','" + product.productSupplier + "','" + product.productPrice + "','" + product.productImage + "')"))
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
                if(imageName.Length > 100)
                {
                    MessageBox.Show("Error:\nImage's name must not have more than 100 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxProductID.Text.Length > 5 || tbxProductID.Text.Length < 5)
                {
                    MessageBox.Show("Error:\nProduct's ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxProductName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nProduct's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxProductType.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nProduct's type must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxEvent.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nThe event must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
