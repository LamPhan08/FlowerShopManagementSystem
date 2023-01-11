using System.Windows;
using System.Windows.Input;

namespace FlowerShopManagementSystem.NotificationBox
{
    /// <summary>
    /// Interaction logic for CannotDeleteBox.xaml
    /// </summary>
    public partial class CannotDeleteBox : Window
    {
        public CannotDeleteBox()
        {
            InitializeComponent();
        }

        private void exitCannotDeleteBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCloseBox_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
