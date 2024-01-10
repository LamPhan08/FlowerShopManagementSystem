using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using FlowerShopManagementSystem.Accounts.StrategyForAccount_ErrorHandling;
using FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for EditAccountForm.xaml
    /// </summary>
    public partial class EditAccountForm : Window
    {
        string imageToEdit, imageName;
        Account newAccountInfo;
        private IErrorHandlingStrategy errorHandlingStrategy;
        private IAccountStrategy _strategy;

        public EditAccountForm()
        {
            InitializeComponent();
            notify.Visibility = Visibility.Hidden;
            errorHandlingStrategy = new DefaultErrorHandlingStrategy(); // Set a default strategy
            _strategy = new DefaultAccountStrategy();
        }
        public void SetAccountStrategy(IAccountStrategy strategy)
        {
            _strategy = strategy;
        }

        private void btnBackEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEditEmployeeID.Text == "" || tbxEditEmployeeName.Text == ""
                || tbxEditEmployeePhoneNumber.Text == "" || dpkEditWorkingDate.Text == ""
                || tbxEditUsername.Text == "" || tbxEditPassword.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                UpdateSupplier();
            }
        }

        private void tbxEditEmployeePhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void editAvatarBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.*)|*.*";
            openFile.FileName = "avatar1.jpg";

            if (openFile.ShowDialog() == true)
            {
                imageToEdit = openFile.FileName;
                editavatar.ImageSource = new BitmapImage(new Uri(imageToEdit));
            }
        }

        private void cbbEditAccountPriority_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void cbbEditAccountPriority_DropDownClosed(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEmployeeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEmployeeName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditEmployeePhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void dpkEditWorkingDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEditPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void UpdateSupplier()
        {
            SetAccountStrategy(new EditAccountStrategy(this));
            _strategy.Execute(newAccountInfo, imageToEdit, imageName);
        }
    }
}
