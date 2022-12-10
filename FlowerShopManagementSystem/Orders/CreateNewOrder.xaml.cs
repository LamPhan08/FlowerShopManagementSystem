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
    /// Interaction logic for CreateNewOrder.xaml
    /// </summary>
    public partial class CreateNewOrder : Window
    {
        private List<CTHD> cTHDs = new List<CTHD>();

        public CreateNewOrder()
        {
            InitializeComponent();

            

            cTHDs.Add(new CTHD {sttSanPham = "1", productID = "SP01", productName="Hoa hồng", productQuantity = 2, productPrice =3000, productTotalMoney = 6000});
            cTHDs.Add(new CTHD { sttSanPham = "2", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "3", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "4", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });
            cTHDs.Add(new CTHD { sttSanPham = "5", productID = "SP01", productName = "Hoa hồng", productQuantity = 2, productPrice = 3000, productTotalMoney = 6000 });


            orderDetailsDataGrid.ItemsSource = cTHDs;



        }

        

        private void tbxCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void chooseProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseProduct chooseProduct = new ChooseProduct();
            chooseProduct.ShowDialog();
        }

        private void btnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBackCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {

        }


        private void orderDetailsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            long total = 0;

            for (int i = 0; i < cTHDs.Count; i++)
            {
                total += cTHDs[i].productTotalMoney;
            }

            
            txtblckTotalMoney.Text = total.ToString();
        }
    }

    public class CTHD
    {
        public string sttSanPham { get; set; }
        public string productID { get; set; }
        public string productName { get; set; }
        public long productPrice { get; set; }
        public int productQuantity { get; set; }
        public long productTotalMoney { get; set; }
    }
}
