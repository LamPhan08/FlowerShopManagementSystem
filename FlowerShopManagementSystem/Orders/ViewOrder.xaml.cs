using FlowerShopManagementSystem.Orders.OrderState;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace FlowerShopManagementSystem.Orders
{
    /// <summary>
    /// Interaction logic for ViewOrder.xaml
    /// </summary>
    public partial class ViewOrder : Window
    {
        List<CTHD> cthds;
        HOA_DON hd1;
        private IOrderState orderState;
        public ViewOrder(HOA_DON hd)
        {
            InitializeComponent();
            cthds = new List<CTHD>();
            hd1 = new HOA_DON(hd);
            if(hd.TINHTRANG == "Paid")
            {
                orderState = new PaidState();
            }
            else
            {
                orderState = new UnpaidState();
            }
            LoadData(cthds, hd1);
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
            try
            {
                orderState.PrintInvoice(this, hd1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            orderState.HandlePayment(this, hd1);
        }

        private void LoadData(List<CTHD> cthds, HOA_DON hd)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select * from CTHD where MAHD = '" + hd.MAHD + "'"),
                    result1;
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    result1 = new Database("RESULT1", "select * from SAN_PHAM where MASP = '" + results.Rows[i][1].ToString() + "'");
                    cthds.Add(new CTHD
                    {
                        sttSanPham = (i + 1).ToString(),
                        productID = results.Rows[i][1].ToString(),
                        productName = result1.Rows[0][1].ToString(),
                        productPrice = double.Parse(result1.Rows[0][5].ToString()),
                        productQuantity = int.Parse(results.Rows[i][2].ToString()),
                        productTotalMoney = double.Parse(results.Rows[i][3].ToString()),
                    });
                }
                viewOrderDetailsDataGrid.ItemsSource = cthds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
