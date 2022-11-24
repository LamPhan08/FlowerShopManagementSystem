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
        public DashboardView()
        {
            InitializeComponent();

            List<exampleProduct> products = new List<exampleProduct>();

            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa mai.jpg", productName1 = "Hoa mai", productPrice1 = 100 });
            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa đào.jpg", productName1 = "Hoa đào", productPrice1 = 100 });
            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa hồng.jpg", productName1 = "Hoa hồng", productPrice1 = 100 });
            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa lan.jpg", productName1 = "Hoa lan", productPrice1 = 100 });
            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa ly.jpg", productName1 = "Hoa ly", productPrice1 = 100 });
            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa cúc.jpg", productName1 = "Hoa cúc", productPrice1 = 100 });
            products.Add(new exampleProduct { productImage1 = "/Products/Product Image/Hoa vạn thọ.png", productName1 = "Hoa vạn thọ", productPrice1 = 100 });

            ListViewProducts.ItemsSource = products;
        }

    }

    public class exampleProduct
    {
        public string productName1 { get; set; }
        public double productPrice1 { get; set; }
        public string productImage1 { get; set; }

      
    }
}
