using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlowerShopManagementSystem.Products
{
    /// <summary>
    /// Interaction logic for AddProductForm.xaml
    /// </summary>
    public partial class AddProductForm : Window
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void tbxProductPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBackAddProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void uploadProductImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png";

            if (openFile.ShowDialog() == true)
            {
                productImage.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }
    }
}
