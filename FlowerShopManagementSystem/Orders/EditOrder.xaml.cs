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
        public EditOrder()
        {
            InitializeComponent();
        }

        private void btnEditFind_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaveOrder_Click(object sender, RoutedEventArgs e)
        {

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

        }


        private void btnEditRemoveProduct_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
