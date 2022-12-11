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

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for EditSupplierForm.xaml
    /// </summary>
    public partial class EditSupplierForm : Window
    {
        public EditSupplierForm()
        {
            InitializeComponent();
        }

        private void btnEditSaveSuppier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditBackSupplier_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbbEditSupplierWard_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void cbbEditSupplierWard_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbbEditSupplierDistrict_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void cbbEditSupplierDistrict_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbbEditSuppierCity_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void cbbEditSuppierCity_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void tbxEditSupplierPhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
