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
using System.Collections.ObjectModel;

namespace FlowerShopManagementSystem.Customers
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : Page
    {
        public CustomersView()
        {
            InitializeComponent();

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { sttKH = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000});
            customers.Add(new Customer { sttKH = "2", name = "Phan", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "3", name = "Doan", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "4", name = "Nguyen", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "5", name = "Hoa", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "6", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "7", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "8", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "9", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "10", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "11", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "12", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "13", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { sttKH = "14", name = "Hahaa", address = "Ho Chi MInh", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });



            customersDataGrid.ItemsSource = customers;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customers.AddCustomerForm addCustomerForm = new Customers.AddCustomerForm();
            addCustomerForm.ShowDialog();

            //Customers.ViewCustomerDetails addCustomerForm = new Customers.ViewCustomerDetails();
            //addCustomerForm.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customers.EditCustomerForm editCustomerForm = new Customers.EditCustomerForm();
            editCustomerForm.ShowDialog();
        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            NotificationBox.DeleteConfirmationBox deleteConfirmationBox = new NotificationBox.DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }

    public class Customer
    {
        public string sttKH { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public string ngayDK { get; set; }

        public long doanhSo { get; set; }
    }
}
