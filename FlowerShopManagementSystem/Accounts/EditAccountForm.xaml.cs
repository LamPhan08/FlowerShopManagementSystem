using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for EditAccountForm.xaml
    /// </summary>
    public partial class EditAccountForm : Window
    {
        string imageToEdit, imageName;
        Account newAccountInfo;

        public EditAccountForm()
        {
            InitializeComponent();
            
            notify.Visibility = Visibility.Hidden;
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
            try
            {
                newAccountInfo = new Account();
                newAccountInfo.employeeCode = tbxEditEmployeeID.Text.ToString();
                newAccountInfo.employeeName = tbxEditEmployeeName.Text.ToString();
                newAccountInfo.employeePhone = tbxEditEmployeePhoneNumber.Text.ToString();
                newAccountInfo.workingDate = dpkEditWorkingDate.Text.ToString();
                newAccountInfo.username = tbxEditUsername.Text.ToString();
                newAccountInfo.password = tbxEditPassword.Text.ToString();
                if (imageToEdit != "")
                {
                    imageName = System.IO.Path.GetFileName(imageToEdit);
                    newAccountInfo.avatarTK = imageName;
                    if (!System.IO.File.Exists("../../Accounts/AccountAvatar/" + imageName))
                    {
                        System.IO.File.Copy(imageToEdit, "../../Accounts/AccountAvatar/" + imageName);
                    }
                }
                ComboBoxItem priorityCBI = (ComboBoxItem)cbbEditAccountPriority.SelectedItem;
                if (priorityCBI.Content.ToString() == "Manager")
                {
                    newAccountInfo.priority = "1";
                }
                else
                {
                    newAccountInfo.priority = "0";
                }
                if (newAccountInfo.avatarTK != AccountsView.accountOldInfo.avatarTK)
                {
                    using (var sqlConnection = new SqlConnection(Database.connection))
                    using (var cmd = new SqlDataAdapter())
                    using (var insertCommand = new SqlCommand(
                        "update NHAN_VIEN " +
                        "set HOTEN = '" + newAccountInfo.employeeName + "', SODT = '" + newAccountInfo.employeePhone + "', NGVL = '" + newAccountInfo.workingDate + "', USERNAME = '" + newAccountInfo.username + "', USER_PASSWORD = '" + newAccountInfo.password + "', USER_PRIORITY = '" + newAccountInfo.priority + "', AVATAR = '" + newAccountInfo.avatarTK + "' " +
                        "where MANV = '" + newAccountInfo.employeeCode + "'"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var sqlConnection = new SqlConnection(Database.connection))
                    using (var cmd = new SqlDataAdapter())
                    using (var insertCommand = new SqlCommand(
                        "update NHAN_VIEN " +
                        "set HOTEN = '" + newAccountInfo.employeeName + "', SODT = '" + newAccountInfo.employeePhone + "', NGVL = '" + newAccountInfo.workingDate + "', USERNAME = '" + newAccountInfo.username + "', USER_PASSWORD = '" + newAccountInfo.password + "', USER_PRIORITY = '" + newAccountInfo.priority + "' " +
                        "where MANV = '" + newAccountInfo.employeeCode + "'"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                if (tbxEditEmployeeID.Text.Length < 5 || tbxEditEmployeeID.Text.Length > 5)
                {
                    MessageBox.Show("Error:\nEmployee ID must not have more/less than 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditEmployeeName.Text.Length > 40)
                {
                    MessageBox.Show("Error:\nEmployee's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditEmployeePhoneNumber.Text.Length < 10 || tbxEditEmployeePhoneNumber.Text.Length > 11)
                {
                    MessageBox.Show("Error:\nEmployee ID must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditUsername.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nEmployee's username must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (tbxEditPassword.Text.Length > 50)
                {
                    MessageBox.Show("Error:\nEmployee's password must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (imageName.Length > 100)
                {
                    MessageBox.Show("Error:\nImage's name must not have more than 100 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
