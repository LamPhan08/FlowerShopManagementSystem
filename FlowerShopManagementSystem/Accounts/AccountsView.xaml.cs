using FlowerShopManagementSystem.NotificationBox;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for AccountsView.xaml
    /// </summary>
    public partial class AccountsView : Page
    {
        List<Account> accounts;
        public static Account accountOldInfo;
        PasswordGenerator generator = new PasswordGenerator();
        Resources.PagingCollectionView view;

        public AccountsView()
        {
            InitializeComponent();

            accounts = new List<Account>();
            LoadData(accounts);
        }

        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccountForm accountForm = new AddAccountForm();
            accountForm.tbxPassword.Text = generator.GeneratePassword();
            accountForm.ShowDialog();
            ReloadData(accounts);
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm();
            accountOldInfo = (Account)accountsDataGrid.SelectedItem;
            string employeeID = accountOldInfo.employeeCode.Trim(),
                    employeeName = accountOldInfo.employeeName.Trim(),
                    employeePhoneNumber = accountOldInfo.employeePhone.Trim(),
                    employeeWorkingDate = accountOldInfo.workingDate.Trim(),
                    employeeUsername = accountOldInfo.username.Trim(),
                    employeePassword = accountOldInfo.password.Trim();
            string employeeAvatar = accountOldInfo.avatarTK.Trim();
            string[] imageNameParts = employeeAvatar.Split('/');
            string employeePriority = accountOldInfo.priority;
            editAccountForm.tbxEditEmployeeID.Text = employeeID;
            editAccountForm.tbxEditEmployeeName.Text = employeeName;
            editAccountForm.tbxEditEmployeePhoneNumber.Text = employeePhoneNumber;
            editAccountForm.dpkEditWorkingDate.Text = employeeWorkingDate;
            editAccountForm.tbxEditUsername.Text = employeeUsername;
            editAccountForm.tbxEditPassword.Text = employeePassword;
            editAccountForm.editavatar.ImageSource = new BitmapImage(new Uri(@"../../Accounts/AccountAvatar/" + imageNameParts[imageNameParts.Length - 1], UriKind.Relative));
            if (employeePriority == "0")
            {
                editAccountForm.cbbEditAccountPriority.Text = "Employee";
            }
            else
            {
                editAccountForm.cbbEditAccountPriority.Text = "Manager";
            }
            editAccountForm.ShowDialog();
            ReloadData(accounts);
        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            DeleteConfirmationBox deleteConfirmationBox = new DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
            if (DeleteConfirmationBox.isDeleteBtnClicked)
            {
                try
                {
                    Account account = (Account)accountsDataGrid.SelectedItem;
                    Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                    using (var sqlConnection = new SqlConnection(Database.connection))
                    using (var cmd = new SqlDataAdapter())
                    using (var insertCommand = new SqlCommand("delete from NHAN_VIEN where MANV = '" + account.employeeCode + "'"))
                    {
                        insertCommand.Connection = sqlConnection;
                        cmd.InsertCommand = insertCommand;
                        sqlConnection.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            ReloadData(accounts);
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ViewAccountDetails viewAccount = new ViewAccountDetails();
            Account selectedAccount = (Account)accountsDataGrid.SelectedItem as Account;
            viewAccount.txtblckEmployeeID.Text = selectedAccount.employeeCode;
            viewAccount.txtblckEmployeeName.Text = selectedAccount.employeeName;
            viewAccount.txtblckEmployeePhone.Text = selectedAccount.employeePhone;
            viewAccount.txtblckWorkingDate.Text = selectedAccount.workingDate;
            viewAccount.txtblckUsername.Text = selectedAccount.username;
            viewAccount.txtblckPassword.Text = selectedAccount.password;
            string employeeAvatar = selectedAccount.avatarTK.Trim();
            string[] imageParts = employeeAvatar.Split('/');
            viewAccount.avatarIB.ImageSource = new BitmapImage(new Uri(@"../../Accounts/AccountAvatar/" + imageParts[imageParts.Length - 1], UriKind.Relative));
            if (selectedAccount.priority == "0")
            {
                viewAccount.txtblckPriority.Text = "Employee";
            }
            else
            {
                viewAccount.txtblckPriority.Text = "Manager";
            }
            viewAccount.ShowDialog();
        }

        public void LoadData(List<Account> accounts)
        {
            try
            {
                Database.connection = "Server=" + Database.connectionName + ";Database=FlowerShopManagement;Integrated Security=true";
                Database results = new Database("RESULT", "select * from NHAN_VIEN");
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    accounts.Add(new Account
                    {
                        sttTK = (i + 1),
                        employeeCode = results.Rows[i][0].ToString(),
                        employeeName = results.Rows[i][1].ToString(),
                        employeePhone = results.Rows[i][2].ToString(),
                        workingDate = results.Rows[i][3].ToString().Substring(0, 10),
                        username = results.Rows[i][4].ToString(),
                        password = results.Rows[i][5].ToString(),
                        priority = results.Rows[i][6].ToString(),
                        avatarTK = "/Accounts/AccountAvatar/" + results.Rows[i][7].ToString()
                    });
                }
                view = new Resources.PagingCollectionView(accounts, 2);

                this.DataContext = view;
                accountsDataGrid.ItemsSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void ReloadData(List<Account> accounts)
        {
            try
            {
                accounts = new List<Account>();
                LoadData(accounts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToFirstPage();
        }

        private void btnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToPreviousPage();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToNextPage();
        }

        private void btnLastPage_Click(object sender, RoutedEventArgs e)
        {
            view.MoveToLastPage();
        }
    }

    public class Account
    {
        public int sttTK { get; set; }
        public string employeeCode { get; set; }
        public string employeeName { get; set; }
        public string employeePhone { get; set; }
        public string workingDate { get; set; }
        public string avatarTK { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string priority { get; set; }
    }
}
