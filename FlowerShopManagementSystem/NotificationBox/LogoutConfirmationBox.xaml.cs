using System.Windows;
using System.Windows.Input;

namespace FlowerShopManagementSystem.NotificationBox
{
    /// <summary>
    /// Interaction logic for LogoutConfirmationBox.xaml
    /// </summary>
    public partial class LogoutConfirmationBox : Window
    {
        public LogoutConfirmationBox()
        {
            InitializeComponent();

            MainWindow.isLogout = true;
        }

        private void exitLogoutBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.isLogout = false;

            this.Close();
        }

        private void btnCancelLogoutBox_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.isLogout = false;

            this.Close();
        }

        private void btnLogoutBox_Click(object sender, RoutedEventArgs e)
        {

            Login login = new Login();

            this.Close();

            login.Show();

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
