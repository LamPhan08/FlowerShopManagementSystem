using System.Windows;

namespace FlowerShopManagementSystem.Products
{
    /// <summary>
    /// Interaction logic for ViewProductDetails.xaml
    /// </summary>
    public partial class ViewProductDetails : Window
    {
        public ViewProductDetails()
        {
            InitializeComponent();
        }

        private void btnBackViewProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
