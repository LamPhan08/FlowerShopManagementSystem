using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace FlowerShopManagementSystem.Orders
{
    /// <summary>
    /// Interaction logic for ChooseProduct.xaml
    /// </summary>
    public partial class ChooseProduct : Window
    {
        List<Product> products;
        public static Product selectedItem;
        public static CTHD selectedCTHD;
        public static List<CTHD> cthdList;
        public static int stt = 0;
        public static bool isListEmpty;
        public static double totalMoney;
        public ChooseProduct()
        {
            InitializeComponent();

            isListEmpty = false;

            products = new List<Product>();

            cthdList = new List<CTHD>();

            totalMoney = 0;

            LoadData(products);
        }

        private void btnFindProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExitChooseProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnProductIn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cthdList == null)
            {
                isListEmpty = true;
            }
            Close();
        }

        private void LoadData(List<Product> products)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select * from SAN_PHAM");
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    products.Add(new Product
                    {
                        productID = results.Rows[i][0].ToString(),
                        productName = results.Rows[i][1].ToString(),
                        productSupplier = results.Rows[i][4].ToString(),
                        productPrice = double.Parse(results.Rows[i][5].ToString()),
                        productImage = "/Products/Product Image/" + results.Rows[i][6].ToString()
                    });
                }
                ListProductsChoose.ItemsSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void itemChB_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            selectedItem = checkBox.DataContext as Product;
            AddTempProduct();
        }

        private void itemChB_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            selectedItem = checkBox.DataContext as Product;
            RemoveTempProduct();
        }

        protected void AddTempProduct()
        {
            try
            {
                cthdList.Add(new CTHD
                {
                    sttSanPham = (stt + 1).ToString(),
                    productID = selectedItem.productID,
                    productName = selectedItem.productName,
                    productPrice = selectedItem.productPrice,
                    productQuantity = 1,
                    productTotalMoney = selectedItem.productPrice
                });

                totalMoney += selectedItem.productPrice;
            }
            catch
            {
                MessageBox.Show("Error:\nYou cannot choose the same product!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                selectedItem.IsChecked = false;
            }
        }

        protected void RemoveTempProduct()
        {
            try
            {
                var index = cthdList.FindIndex(a => a.productID == selectedItem.productID);
                totalMoney -= selectedItem.productPrice;
                cthdList.RemoveAt(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnFirstPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPreviousPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLastPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Product : INotifyPropertyChanged
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productImage { get; set; }
        public string productSupplier { get; set; }

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
