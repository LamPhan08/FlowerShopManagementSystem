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

namespace FlowerShopManagementSystem.View
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

            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000});
            customers.Add(new Customer { stt = "2", name = "Phan", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "3", name = "Doan", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "4", name = "Nguyen", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "5", name = "Hoa", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Lam", address = "Thu Duc", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });
            customers.Add(new Customer { stt = "1", name = "Hahaa", address = "Ho Chi MInh", phone = "0123456789", ngayDK = "5/11/2022", doanhSo = 1000000 });



            customersDataGrid.ItemsSource = customers;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }
    }

    public class Customer
    {
        public string stt { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public string ngayDK { get; set; }

        public long doanhSo { get; set; }
    }
}
