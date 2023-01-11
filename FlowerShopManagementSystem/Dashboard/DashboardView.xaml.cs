using FlowerShopManagementSystem.Orders;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Dashboard
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : Page
    {
        public static bool isOneProdOnly;
        List<Product> products = new List<Product>();
        static int stt = 1;
        Resources.PagingCollectionView view;
        public DashboardView()
        {
            InitializeComponent();
            isOneProdOnly = false;

            RadioButton[] buttons = new RadioButton[7]
            {
                new RadioButton(),
                new RadioButton(),
                new RadioButton(),
                new RadioButton(),
                new RadioButton(),
                new RadioButton(),
                new RadioButton()
            };
            buttons[0].IsChecked = true;
            buttons[0].Content = "ALL";
            buttons[1].Content = "LOVE";
            buttons[2].Content = "BIRTHDAY";
            buttons[3].Content = "NEW";
            buttons[4].Content = "OFFICE";
            buttons[5].Content = "CONGRATS";
            buttons[6].Content = "CONDOLENCE";

            foreach (var button in buttons)
            {
                button.Click += Button_Click;
                var style = Application.Current.TryFindResource("buttonFilter") as Style;
                button.Style = style;
                stkpnl.Children.Add(button);
            }

            LoadData(products);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as RadioButton;
            string filter = button.Content.ToString();
            LoadDataViaFilter(products, filter);
        }

        private void shiftLeft_Click(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToHorizontalOffset(scroll.HorizontalOffset - 200);
        }

        private void shiftRight_Click(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToHorizontalOffset(scroll.HorizontalOffset + 200);
        }

        private void btnDashboardProductIn4_Click(object sender, RoutedEventArgs e)
        {
            ViewDashboardProduct viewDashboardProduct = new ViewDashboardProduct();
            Button btn = sender as Button;
            Product selectedProduct = btn.DataContext as Product;
            viewDashboardProduct.txtblckProductID.Text = selectedProduct.productCode;
            viewDashboardProduct.txtblckProductName.Text = selectedProduct.productName;
            viewDashboardProduct.txtblckProductType.Text = selectedProduct.productType;
            viewDashboardProduct.txtblckEvent.Text = selectedProduct.productOccasion.ToUpper();
            Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
            Database TableRight = new Database("RESULT", "select * from NHA_CUNG_CAP where MANCC = '" + selectedProduct.productSupplier + "'");
            viewDashboardProduct.txtblckProductSupplier.Text = TableRight.Rows[0][1].ToString();
            viewDashboardProduct.txtblckProductPrice.Text = selectedProduct.productPrice.ToString();
            string productImage = selectedProduct.productImage.Trim();
            string[] imageParts = productImage.Split('/');
            viewDashboardProduct.viewProductImage.Source = new BitmapImage(new Uri(@"../../Products/Product Image/" + imageParts[imageParts.Length - 1], UriKind.Relative));
            viewDashboardProduct.ShowDialog();
        }


        private void btnShopping_Click(object sender, RoutedEventArgs e)
        {
            isOneProdOnly = true;
            Orders.CreateNewOrder newOrder = new Orders.CreateNewOrder();
            Button btn = sender as Button;
            Product ct = btn.DataContext as Product;
            newOrder.cTHDs.Add(new CTHD
            {
                sttSanPham = stt.ToString(),
                productID = ct.productCode,
                productName = ct.productName,
                productPrice = ct.productPrice,
                productQuantity = 1,
                productTotalMoney = ct.productPrice,
            });
            ChooseProduct.totalMoney = 0;
            ChooseProduct.totalMoney += ct.productPrice;
            newOrder.ShowDialog();
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
                        productCode = results.Rows[i][0].ToString(),
                        productName = results.Rows[i][1].ToString(),
                        productType = results.Rows[i][2].ToString(),
                        productOccasion = results.Rows[i][3].ToString(),
                        productSupplier = results.Rows[i][4].ToString(),
                        productPrice = double.Parse(results.Rows[i][5].ToString()),
                        productImage = "/Products/Product Image/" + results.Rows[i][6].ToString()
                    });
                }
                view = new Resources.PagingCollectionView(products, 12);

                this.DataContext = view;
                DashboardProductsList.ItemsSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadDataViaFilter(List<Product> products, string filter)
        {
            try
            {
                products = new List<Product>();
                string additionalQuery = filter == "ALL" ? "" : " where SU_KIEN = '" + filter.ToLower() + "'";
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select * from SAN_PHAM" + additionalQuery);
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    products.Add(new Product
                    {
                        productCode = results.Rows[i][0].ToString(),
                        productName = results.Rows[i][1].ToString(),
                        productType = results.Rows[i][2].ToString(),
                        productOccasion = results.Rows[i][3].ToString(),
                        productSupplier = results.Rows[i][4].ToString(),
                        productPrice = double.Parse(results.Rows[i][5].ToString()),
                        productImage = "/Products/Product Image/" + results.Rows[i][6].ToString()
                    });
                }
                view = new Resources.PagingCollectionView(products, 12);

                this.DataContext = view;
                DashboardProductsList.ItemsSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToFirstPage();
        }

        private void btnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToPreviousPage();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToNextPage();
        }

        private void btnLastPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToLastPage();
        }
    }

    public class filterButton
    {
        public string buttonContent { get; set; }
    }

    public class Product
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productImage { get; set; }
        public string productOccasion { get; set; }
        public string productType { get; set; }
        public string productSupplier { get; set; }
    }
}
