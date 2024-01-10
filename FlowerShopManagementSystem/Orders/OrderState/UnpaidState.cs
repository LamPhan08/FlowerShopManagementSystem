using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.Orders.OrderState
{
    public class UnpaidState : IOrderState
    {
        public void PrintInvoice(ViewOrder viewOrder, HOA_DON order)
        {
            MessageBox.Show("Please make a payment first!", "Message:", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public void HandlePayment(ViewOrder viewOrder, HOA_DON hd1)
        {
            NotificationBox.PaymentConfirmation confirmation = new NotificationBox.PaymentConfirmation();
            confirmation.ShowDialog();
            if (NotificationBox.PaymentConfirmation.isBtnConfirmClicked)
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand(
                    "update HOA_DON " +
                    "set TINHTRANG = 'Paid' " +
                    "where MAHD = '" + hd1.MAHD + "'"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                viewOrder.btnPayment.Visibility = Visibility.Hidden;
                viewOrder.orderStatusPanel.Visibility = Visibility.Visible;

                viewOrder.btnPrintInvoice.Opacity = 1;
                viewOrder.btnPrintInvoice.IsEnabled = true;
            }
        }
    }
}
