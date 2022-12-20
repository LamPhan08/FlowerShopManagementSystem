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
    /// Interaction logic for Invoice.xaml
    /// </summary>
    public partial class Invoice : Window
    {
        private List<CTHD> cTHDs = new List<CTHD>();

        public Invoice()
        {
            InitializeComponent();

            cTHDs.Add(new CTHD { sttSanPham = "1", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "2", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "3", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });


            invoiceDetails.ItemsSource = cTHDs;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                btnPrint.Visibility = Visibility.Hidden;
                PrintDialog printDialog = new PrintDialog();

                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(grdPrint, "Invoice");
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void invoiceDetails_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            long total = 0;

            for (int i = 0; i < cTHDs.Count; i++)
            {
                total += cTHDs[i].productTotalMoney;
            }


            txbTotal.Text = total.ToString() + "$";
        }

        private void wdBillTemplate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }


}
