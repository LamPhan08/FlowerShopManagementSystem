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

namespace FlowerShopManagementSystem.Dashboard
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : Page
    {
        public DashboardView()
        {
            InitializeComponent();

            List<filterButton> filters = new List<filterButton>();

            filters.Add(new filterButton { buttonContent = "Tất cả" });
            filters.Add(new filterButton { buttonContent = "Tình yêu" });
            filters.Add(new filterButton { buttonContent = "Đám tang" });
            filters.Add(new filterButton { buttonContent = "Đám cưới" });
            filters.Add(new filterButton { buttonContent = "Tất cả" });
            filters.Add(new filterButton { buttonContent = "Tình yêu" });
            filters.Add(new filterButton { buttonContent = "Đám tang" });
            filters.Add(new filterButton { buttonContent = "Đám cưới" });
            filters.Add(new filterButton { buttonContent = "Tất cả" });
            filters.Add(new filterButton { buttonContent = "Tình yêu" });
            filters.Add(new filterButton { buttonContent = "Đám tang" });
            filters.Add(new filterButton { buttonContent = "Đám cưới" });

            ListViewButton.ItemsSource = filters;

        }


        private void leftBtn_Click(object sender, RoutedEventArgs e)
        {
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset - 200);

        }

        private void rightBtn_Click(object sender, RoutedEventArgs e)
        {
            sv.ScrollToHorizontalOffset(sv.HorizontalOffset + 200);
        }
    }

    public class filterButton
    {
        public string buttonContent { get; set; }
    }
}
