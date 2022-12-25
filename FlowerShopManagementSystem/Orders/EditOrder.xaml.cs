using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EditOrder.xaml
    /// </summary>
    public partial class EditOrder : Window
    {
        private List<CTHD> cTHDs = new List<CTHD>();

        public EditOrder()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;
            findNotify.Visibility = Visibility.Hidden;

            cTHDs.Add(new CTHD { sttSanPham = "1", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "2", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "3", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "4", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "5", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "6", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "7", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "8", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "9", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "10", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });

            editOrderDetailsDataGrid.ItemsSource = cTHDs;

        }

        private void btnEditFind_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditCustomerPhone.Text == "0123456789")
            {
                tbxEditCustomerName.Text = "Phan Nhat Lam";
            }
            else
            {
                findNotify.Visibility = Visibility.Visible;
            }
        }

        private void btnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditOrderID.Text == "" || tbxEditCustomerPhone.Text == ""
                || tbxEditCustomerName.Text == "" || cTHDs.Count == 0)
            {
                notify.Visibility = Visibility.Visible;

            }
        }

        private void btnBackEditOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editChooseProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseProduct chooseProduct = new ChooseProduct();
            chooseProduct.ShowDialog();
        }

        private void tbxEditCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void editOrderDetailsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            long total = 0;

            for (int i = 0; i < cTHDs.Count; i++)
            {
                total += cTHDs[i].productTotalMoney;
            }


            txtblckTotalMoney.Text = total.ToString();
        }


        private void btnEditRemoveProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbxEditOrderID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditCustomerPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
            findNotify.Visibility = Visibility.Hidden;
        }

        private void tbxEditCustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void btnProductIn4_Click(object sender, RoutedEventArgs e)
        {
            ProductIn4 productIn4 = new ProductIn4();
            productIn4.ShowDialog();
        }
    }
}
