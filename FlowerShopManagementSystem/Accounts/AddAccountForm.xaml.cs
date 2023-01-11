using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for AddAccountForm.xaml
    /// </summary>
    public partial class AddAccountForm : Window
    {
        string image, imageName;
        AccountsView accountsView;

        public AddAccountForm()
        {
            InitializeComponent();

            notify.Visibility = Visibility.Hidden;
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
            try
            {
                accountsView = new AccountsView();
                Account account = new Account();
                account.employeeCode = tbxEmployeeID.Text.ToString();
                account.employeeName = tbxEmployeeName.Text.ToString();
                account.employeePhone = tbxEmployeePhoneNumber.Text.ToString();
                account.workingDate = dpkWorkingDate.Text.ToString();
                account.username = tbxUsername.Text.ToString();
                account.password = tbxPassword.Text.ToString();
                if (image != "")
                {
                    imageName = System.IO.Path.GetFileName(image);
                    account.avatarTK = imageName;
                    if (!System.IO.File.Exists("../../Accounts/AccountAvatar/" + imageName))
                    {
                        System.IO.File.Copy(image, "../../Accounts/AccountAvatar/" + imageName);
                    }
                }
                if (cbbAccountPriority.Text.ToString() == "Manager")
                {
                    account.priority = "1";
                }
                else
                {
                    account.priority = "0";
                }
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand("insert into NHAN_VIEN(MANV, HOTEN, SODT, NGVL, USERNAME, USER_PASSWORD, USER_PRIORITY, AVATAR) " +
                    "values ('" + account.employeeCode + "','" + account.employeeName + "','" + account.employeePhone + "','" + account.workingDate + "','" + account.username + "','" + account.password + "','" + account.priority + "','" + account.avatarTK + "')"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch (Exception)
            {
                if(tbxEmployeeID.Text.Length < 5 || tbxEmployeeID.Text.Length > 5)
                {
                    MessageBox.Show("Error:\nEmployee ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxEmployeeName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nEmployee's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxEmployeePhoneNumber.Text.Length < 10 || tbxEmployeePhoneNumber.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nEmployee ID must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxUsername.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nEmployee's username must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(tbxPassword.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nEmployee's password must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(imageName.Length > 100)
                {
                    MessageBox.Show("Error:\nImage's name must not have more than 100 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
