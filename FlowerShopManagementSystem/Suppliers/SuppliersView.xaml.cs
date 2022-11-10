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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowerShopManagementSystem.Suppliers
{
    /// <summary>
    /// Interaction logic for SuppliersView.xaml
    /// </summary>
    public partial class SuppliersView : Page
    {
        public SuppliersView()
        {
            InitializeComponent();

            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier(){ sttNCC = "1", maNCC = "NCC1", tenNCC="UIT", diaChiNCC="Thu Duc", soDTNCC="123"});
            suppliers.Add(new Supplier() { sttNCC = "2", maNCC = "NCC1", tenNCC = "UIT", diaChiNCC = "Thu Duc", soDTNCC = "123" });
            suppliers.Add(new Supplier() { sttNCC = "3", maNCC = "NCC1", tenNCC = "UIT", diaChiNCC = "Thu Duc", soDTNCC = "123" });
            suppliers.Add(new Supplier() { sttNCC = "4", maNCC = "NCC1", tenNCC = "UIT", diaChiNCC = "Thu Duc", soDTNCC = "123" });
            suppliers.Add(new Supplier() { sttNCC = "5", maNCC = "NCC1", tenNCC = "UIT", diaChiNCC = "Thu Duc", soDTNCC = "123" });


            suppliersDataGrid.ItemsSource = suppliers;

        }

        private void btnEditSupplier_Click(object sender, RoutedEventArgs e)
        {
            Suppliers.EditSupplierForm editSupplierForm = new Suppliers.EditSupplierForm();
            editSupplierForm.ShowDialog();
        }

        private void btnDeleteSupplier_Click(object sender, RoutedEventArgs e)
        {
            NotificationBox.DeleteConfirmationBox deleteConfirmationBox = new NotificationBox.DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
        }

        private void btnAddNewSupplier_Click(object sender, RoutedEventArgs e)
        {
            Suppliers.AddSupplierForm supplierForm = new Suppliers.AddSupplierForm();
            supplierForm.ShowDialog();
        }
    }

    public class Supplier
    {
        public string sttNCC { get; set; }
        public string maNCC { get; set; }
        public string tenNCC { get; set; }
        public string diaChiNCC { get; set; }
        public string soDTNCC { get; set; }
    }
}
