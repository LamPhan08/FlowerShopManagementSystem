using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.Orders.OrderState
{
    public class PaidState : IOrderState
    {
        public void PrintInvoice(ViewOrder viewOrder, HOA_DON hd)
        {
            Invoice invoice = new Invoice(hd);
            invoice.txbBillId.Text = hd.MAHD;
            invoice.txbInvoiceDate.Text = hd.NGHD;
            Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
            Database results = new Database("RESULT", "select * from KHACH_HANG where SODT_KH = '" + hd.SODT_KH + "'"),
                results1 = new Database("RESULT", "select * from NHAN_VIEN where MANV = '" + hd.MANV + "'");
            invoice.txbCustomerName.Text = results.Rows[0][1].ToString();
            invoice.txbCustomerPhoneNumber.Text = hd.SODT_KH;
            invoice.txbTotal.Text = hd.TRIGIA.ToString();
            invoice.txbEmployeeName.Text = results1.Rows[0][1].ToString();
            invoice.ShowDialog();
        }
        public void HandlePayment(ViewOrder viewOrder, HOA_DON order)
        {
            MessageBox.Show("Order is already paid!", "Message:", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
