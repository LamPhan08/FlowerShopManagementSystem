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

namespace FlowerShopManagementSystem.Customers
{
    /// <summary>
    /// Interaction logic for AddCustomerForm.xaml
    /// </summary>
    public partial class AddCustomerForm : Window
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnBackCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbxCustomerSales_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbxCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbbDistrict_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void cbbDistrict_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbbCity_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void cbbCity_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbbProvince_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void cbbProvince_DropDownClosed(object sender, EventArgs e)
        {

        }
    }
}
