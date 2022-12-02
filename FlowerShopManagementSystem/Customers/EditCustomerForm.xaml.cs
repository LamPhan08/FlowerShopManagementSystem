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
    /// Interaction logic for EditCustomerForm.xaml
    /// </summary>
    public partial class EditCustomerForm : Window
    {
        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void btnEditBackCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditSaveCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbxEditCustomerSales_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbxEditCustomerPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
