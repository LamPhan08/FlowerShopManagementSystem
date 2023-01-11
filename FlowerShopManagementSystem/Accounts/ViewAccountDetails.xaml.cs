using System.Windows;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for ViewAccountDetails.xaml
    /// </summary>
    public partial class ViewAccountDetails : Window
    {
        public ViewAccountDetails()
        {
            InitializeComponent();
        }

        private void btnBackViewEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
