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
    /// Interaction logic for EditProductForm.xaml
    /// </summary>
    public partial class EditProductForm : Window
    {
        public EditProductForm()
        {
            InitializeComponent();
        }


        private void btnSaveProduct_Click(object sender, RoutedEventArgs e)
        {

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
            openFile.Filter = "Image Files|*.jpg;*.png";

            if (openFile.ShowDialog() == true)
            {
                editProductImage.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }
    }
}
