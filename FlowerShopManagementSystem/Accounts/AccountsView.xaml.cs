using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FlowerShopManagementSystem.Accounts.CommandForAccount;
using FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD;

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for AccountsView.xaml
    /// </summary>
    public partial class AccountsView : Page
    {
        internal List<Account> accounts;
        public static Account accountOldInfo;
        internal PasswordGenerator generator = new PasswordGenerator();
        Resources.PagingCollectionView view;

        private IAccountViewCommand _addAccountViewCommand;
        private IAccountViewCommand _editAccountViewCommand;

        private AccountInvoker _accountInvoker;


        IAccountStrategy _strategy;

        public AccountsView()
        {
            InitializeComponent();
            #region Command - Client
            AccountReceiver account = new AccountReceiver(this);

            _addAccountViewCommand = new AddAccountViewCommand(account);
            _editAccountViewCommand = new EditAccountViewCommand(account);

            _accountInvoker = new AccountInvoker(_addAccountViewCommand, _editAccountViewCommand);
            #endregion

            #region Strategy - Client
            _strategy = new DefaultAccountStrategy();
            #endregion

            accounts = new List<Account>();
            LoadData(accounts);
        }

        public void SetStrategy(IAccountStrategy strategy)
        {
            _strategy = strategy;
        }

        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            //_addAccountViewCommand.Execute();
            _accountInvoker.viewAddAccountForm();
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e)
        {
            //_editAccountViewCommand.Execute();
            _accountInvoker.viewEditAccountForm();
        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            //_deleteAccountCommand.Execute();
            SetStrategy(new DeleteAccountStrategy(new AccountsView()));
            _strategy.Execute((Account)accountsDataGrid.SelectedItem, "", "");
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SetStrategy(new ReadAccountStrategy());
            _strategy.Execute((Account)accountsDataGrid.SelectedItem as Account, "", "");
            ReloadData(accounts);
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

                if (accounts.Count == 0)
                {
                    accountsCount.Text = "There are no Accounts!";
                }
                else if (accounts.Count == 1)
                {
                    accountsCount.Text = accounts.Count.ToString() + " Account";
                }
                else
                {
                    accountsCount.Text = accounts.Count.ToString() + " Accounts";
                }

                view = new Resources.PagingCollectionView(accounts, 10);

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
}
