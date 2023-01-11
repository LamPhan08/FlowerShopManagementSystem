using FlowerShopManagementSystem.Orders;
using System.Windows;

namespace FlowerShopManagementSystem.Dashboard
{
    /// <summary>
    /// Interaction logic for ViewDashboardProduct.xaml
    /// </summary>
    public partial class ViewDashboardProduct : Window
    {
        public ViewDashboardProduct()
        {
            InitializeComponent();
        }

        private void btnBackViewDashboardProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBackCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            DashboardView.isOneProdOnly = true;
            Orders.CreateNewOrder createNewOrder = new Orders.CreateNewOrder();
            createNewOrder.cTHDs.Add(new CTHD
            {
                sttSanPham = "1",
                productID = txtblckProductID.Text.ToString(),
                productName = txtblckProductName.Text.ToString(),
                productPrice = double.Parse(txtblckProductPrice.Text.ToString()),
                productQuantity = 1,
                productTotalMoney = double.Parse(txtblckProductPrice.Text.ToString()),
            });
            ChooseProduct.totalMoney = 0;
            ChooseProduct.totalMoney += double.Parse(txtblckProductPrice.Text.ToString());
            createNewOrder.ShowDialog();

            this.Close();
        }
    }
}
