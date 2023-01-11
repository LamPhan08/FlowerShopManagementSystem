using System.Windows;
using System.Windows.Input;

namespace FlowerShopManagementSystem.NotificationBox
{
    /// <summary>
    /// Interaction logic for DeleteConfirmationBox.xaml
    /// </summary>
    public partial class DeleteConfirmationBox : Window
    {
        public static bool isDeleteBtnClicked = false;
        public DeleteConfirmationBox()
        {
            InitializeComponent();
            isDeleteBtnClicked = true;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void exitBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            isDeleteBtnClicked = false;
            this.Close();
        }

        private void btnCancelBox_Click(object sender, RoutedEventArgs e)
        {
            isDeleteBtnClicked = false;
            this.Close();
        }

        private void btnDeleteBox_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
