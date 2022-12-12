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

namespace FlowerShopManagementSystem.Dashboard
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : Page
    {
        List<Product> products = new List<Product>();

        public DashboardView()
        {
            InitializeComponent();

            //List<filterButton> filters = new List<filterButton>();

            //filters.Add(new filterButton { buttonContent = "Tất cả" });
            //filters.Add(new filterButton { buttonContent = "Tình yêu" });
            //filters.Add(new filterButton { buttonContent = "Đám tang" });
            //filters.Add(new filterButton { buttonContent = "Đám cưới" });
            //filters.Add(new filterButton { buttonContent = "Tất cả" });
            //filters.Add(new filterButton { buttonContent = "Tình yêu" });
            //filters.Add(new filterButton { buttonContent = "Đám tang" });
            //filters.Add(new filterButton { buttonContent = "Đám cưới" });
            //filters.Add(new filterButton { buttonContent = "Tất cả" });
            //filters.Add(new filterButton { buttonContent = "Tình yêu" });
            //filters.Add(new filterButton { buttonContent = "Đám tang" });
            //filters.Add(new filterButton { buttonContent = "Đám cưới" });

            //listButton.ItemsSource = filters;

            for (int i = 0; i < 10; i++)
            {
                RadioButton button = new RadioButton();

                if (i == 0)
                {
                    button.IsChecked = true;
                    button.Content = "All";
                }
                else
                {
                    button.Content = "Button" + i.ToString();
                }

                button.Click += Button_Click;

                var style = Application.Current.TryFindResource("buttonFilter") as Style;
                button.Style = style;

                stkpnl.Children.Add(button);
            }


            products.Add(new Product { productImage = "/Products/Product Image/Hoa mai.jpg", productName = "Hoa mai", productPrice = 100 });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa đào.jpg", productName = "Hoa đào", productPrice = 100 });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa hồng.jpg", productName = "Hoa hồng", productPrice = 100 });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa lan.jpg", productName = "Hoa lan", productPrice = 100 });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa ly.jpg", productName = "Hoa ly", productPrice = 100 });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa cúc.jpg", productName = "Hoa cúc", productPrice = 100 });
            products.Add(new Product { productImage = "/Products/Product Image/Hoa vạn thọ.png", productName = "Hoa vạn thọ", productPrice = 100 });

            DashboardProductsList.ItemsSource = products;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           var button = sender as RadioButton;
            if (button.Content.ToString() == "All")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa mai.jpg", productName = "Hoa mai", productPrice = 100 });
                products.Add(new Product { productImage = "/Products/Product Image/Hoa đào.jpg", productName = "Hoa đào", productPrice = 100 });
                products.Add(new Product { productImage = "/Products/Product Image/Hoa hồng.jpg", productName = "Hoa hồng", productPrice = 100 });
                products.Add(new Product { productImage = "/Products/Product Image/Hoa lan.jpg", productName = "Hoa lan", productPrice = 100 });
                products.Add(new Product { productImage = "/Products/Product Image/Hoa ly.jpg", productName = "Hoa ly", productPrice = 100 });
                products.Add(new Product { productImage = "/Products/Product Image/Hoa cúc.jpg", productName = "Hoa cúc", productPrice = 100 });
                products.Add(new Product { productImage = "/Products/Product Image/Hoa vạn thọ.png", productName = "Hoa vạn thọ", productPrice = 100 });

                DashboardProductsList.ItemsSource = products;
            }
            else if (button.Content.ToString() == "Button1")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa mai.jpg", productName = "Hoa mai", productPrice = 100 });
                

                DashboardProductsList.ItemsSource = products;

            }
            else if (button.Content.ToString() == "Button2")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa đào.jpg", productName = "Hoa đào", productPrice = 100 });


                DashboardProductsList.ItemsSource = products;

            }
            else if (button.Content.ToString() == "Button3")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa hồng.jpg", productName = "Hoa hồng", productPrice = 100 });

                DashboardProductsList.ItemsSource = products;

            }
            else if (button.Content.ToString() == "Button4")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa lan.jpg", productName = "Hoa lan", productPrice = 100 });

                DashboardProductsList.ItemsSource = products;

            }
            else if (button.Content.ToString() == "Button5")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa ly.jpg", productName = "Hoa ly", productPrice = 100 });
                

                DashboardProductsList.ItemsSource = products;

            }
            else if (button.Content.ToString() == "Button6")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa cúc.jpg", productName = "Hoa cúc", productPrice = 100 });

                DashboardProductsList.ItemsSource = products;

            }
            else if (button.Content.ToString() == "Button7")
            {
                products = new List<Product>();

                products.Add(new Product { productImage = "/Products/Product Image/Hoa vạn thọ.png", productName = "Hoa vạn thọ", productPrice = 100 });

                DashboardProductsList.ItemsSource = products;

            }
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
            viewDashboardProduct.ShowDialog();
        }


        private void btnShopping_Click(object sender, RoutedEventArgs e)
        {
            Orders.CreateNewOrder newOrder = new Orders.CreateNewOrder();
            newOrder.ShowDialog();
        }
    }

    public class filterButton
    {
        public string buttonContent { get; set; }
    }

    public class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productImage { get; set; }

    }
}
