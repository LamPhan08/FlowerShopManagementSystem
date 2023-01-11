using System.Windows;

namespace FlowerShopManagementSystem.Customers
{
    /// <summary>
    /// Interaction logic for ViewCustomerDetails.xaml
    /// </summary>
    public partial class ViewCustomerDetails : Window
    {
        public ViewCustomerDetails()
        {
            InitializeComponent();
        }

        private void btnBackCustomerView_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
