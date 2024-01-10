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
    /// Interaction logic for AddAccountForm.xaml
    /// </summary>
    public partial class AddAccountForm : Window
    {
        private IErrorHandlingStrategy errorHandlingStrategy;
        private IAccountStrategy _strategy;
        string image, imageName;
        AccountsView accountsView;

        public AddAccountForm()
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

        private void btnBackEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (tbxEmployeeID.Text == "" || tbxEmployeeName.Text == ""
                || tbxEmployeePhoneNumber.Text == "" || dpkWorkingDate.Text == ""
                || tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                notify.Visibility = Visibility.Visible;
            }
            else
            {
                AddAccount();
            }
        }

        private void uploadAvatarBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.*)|*.*";
            openFile.FileName = "avatar1.jpg";

            if (openFile.ShowDialog() == true)
            {
                image = openFile.FileName;
                avatar.ImageSource = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void tbxEmployeePhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbbAccountPriority_DropDownOpened(object sender, EventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }


        private void tbxEmployeeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEmployeeName_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxEmployeePhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void dpkWorkingDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;
        }

        private void dpkWorkingDate_GotFocus(object sender, RoutedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void tbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            notify.Visibility = Visibility.Hidden;

        }

        private void AddAccount()
        {
            SetAccountStrategy(new AddAccountStrategy(this));
            _strategy.Execute(new Account(), image, imageName);
        }
    }
}
