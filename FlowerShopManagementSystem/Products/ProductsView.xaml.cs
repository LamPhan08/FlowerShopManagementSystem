using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowerShopManagementSystem.Products
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Page
    {
        public ProductsView()
        {
            InitializeComponent();

            List<Product> products = new List<Product>();

            products.Add(new Product{ productImage = "/Products/Product Image/Hoa mai.jpg", productName = "Hoa mai", productPrice = 100, productSupplier = "123456788989867",  productType="Đám cưới"});
            products.Add(new Product { productImage = "/Products/Product Image/Hoa đào.jpg", productName = "Hoa đào", productPrice = 100, productSupplier = "UIT", productType = "Đám tang" });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa hồng.jpg", productName = "Hoa hồng", productPrice = 100, productSupplier = "UIT", productType = "Tình nhân" });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa lan.jpg", productName = "Hoa lan", productPrice = 100, productSupplier = "UIT", productType = "TIệc" });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa ly.jpg", productName = "Hoa ly", productPrice = 100, productSupplier = "UIT", productType = "..." });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa cúc.jpg", productName = "Hoa cúc", productPrice = 100, productSupplier = "UIT", productType = "..." });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa vạn thọ.png", productName = "Hoa vạn thọ", productPrice = 100, productSupplier = "UIT", productType = "..." });

            ListProducts.ItemsSource = products;

        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            EditProductForm edit = new EditProductForm();
            edit.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            NotificationBox.DeleteConfirmationBox deleteConfirmationBox = new NotificationBox.DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
        }

        private void addProductBtn_Click(object sender, RoutedEventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void btnProductIn4_Click(object sender, RoutedEventArgs e)
        {
            ViewProductDetails viewProductDetails = new ViewProductDetails();
            viewProductDetails.ShowDialog();
        }
    }

    public class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productImage { get; set; }
        public string productType { get; set; }
        public string productSupplier { get; set; }

        //public Product(string name, double price, string image)
        //{
        //    productName = name;
        //    productPrice = price;
        //    productImage = image;
        //}
    } 
}
