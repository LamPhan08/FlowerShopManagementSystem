using System.Windows;

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for ViewSupplierDetails.xaml
    /// </summary>
    public partial class ViewSupplierDetails : Window
    {
        public ViewSupplierDetails()
        {
            InitializeComponent();
        }

        private void btnBackSupplierView_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
