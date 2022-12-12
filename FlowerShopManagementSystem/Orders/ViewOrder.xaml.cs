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
using System.Windows.Shapes;

namespace FlowerShopManagementSystem.Orders
{
    /// <summary>
    /// Interaction logic for ViewOrder.xaml
    /// </summary>
    public partial class ViewOrder : Window
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void btnBackViewOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void viewOrderDetailsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {

        }

        private void btnPrintInvoice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            btnPayment.Visibility = Visibility.Hidden;
            orderStatusPanel.Visibility = Visibility.Visible;

            btnPrintInvoice.Opacity = 1;
            btnPrintInvoice.IsEnabled = true;
        }
    }
}
