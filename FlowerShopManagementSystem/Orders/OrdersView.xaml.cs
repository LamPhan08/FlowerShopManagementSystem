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

namespace FlowerShopManagementSystem.Orders
{
    /// <summary>
    /// Interaction logic for OrdersView.xaml
    /// </summary>
    public partial class OrdersView : Page
    {
        public OrdersView()
        {
            InitializeComponent();

            List<HOA_DON> hoadon = new List<HOA_DON>();

            hoadon.Add(new HOA_DON { MAHD = "HD01", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV01", TRIGIA = 1000000, sttHD = 1, TINHTRANG = "Paid"});
            hoadon.Add(new HOA_DON { MAHD = "HD02", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV02", TRIGIA = 1000000, sttHD = 2, TINHTRANG = "Unpaid" });
            hoadon.Add(new HOA_DON { MAHD = "HD03", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV03", TRIGIA = 1000000, sttHD = 3, TINHTRANG = "Paid" });
            hoadon.Add(new HOA_DON { MAHD = "HD04", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV04", TRIGIA = 1000000, sttHD = 4, TINHTRANG = "Unpaid" });
            hoadon.Add(new HOA_DON { MAHD = "HD05", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV05", TRIGIA = 1000000, sttHD = 5, TINHTRANG = "Paid" });
            hoadon.Add(new HOA_DON { MAHD = "HD06", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV06", TRIGIA = 1000000, sttHD = 6, TINHTRANG = "Unpaid" });
            hoadon.Add(new HOA_DON { MAHD = "HD07", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV07", TRIGIA = 1000000, sttHD = 7, TINHTRANG = "Paid" });
            hoadon.Add(new HOA_DON { MAHD = "HD08", NGHD = DateTime.Now.ToString(), SODT_KH = "0123456789", MANV = "NV08", TRIGIA = 1000000, sttHD = 8, TINHTRANG = "Unpaid" });

            ordersDataGrid.ItemsSource = hoadon;

        }

        private void btnAddNewOrder_Click(object sender, RoutedEventArgs e)
        {
            CreateNewOrder createNewOrder = new CreateNewOrder();
            createNewOrder.ShowDialog();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.ShowDialog();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            EditOrder edit = new EditOrder();
            edit.ShowDialog();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class HOA_DON
    {
        public int sttHD { get; set; }
        public string MAHD { get; set; }
        public string NGHD { get; set; }
        public string SODT_KH { get; set; }
        public string MANV { get; set; }
        public long TRIGIA { get; set; }
        public string TINHTRANG { get; set; }
    }
}
