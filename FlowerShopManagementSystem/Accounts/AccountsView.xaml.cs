﻿using System;
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

namespace FlowerShopManagementSystem.Accounts
{
    /// <summary>
    /// Interaction logic for AccountsView.xaml
    /// </summary>
    public partial class AccountsView : Page
    {
        List<Account> accounts = new List<Account>();
        Resources.PagingCollectionView view;

        public AccountsView()
        {
            InitializeComponent();

            accounts.Add(new Account{ sttTK = 1, employeeCode = "NV01", employeeName="Nguyễn Văn A", employeePhone="0123456789",
                avatarTK= "/Accounts/AccountAvatar/avatar1.jpg", username="tk0123", password="123456", workingDate="24/11/2022", priority="1"});
            accounts.Add(new Account
            {
                sttTK =2,
                employeeCode = "NV02",
                employeeName = "Nguyễn Văn B",
                employeePhone = "0123456789",
                avatarTK = "/Accounts/AccountAvatar/avatar2.jpg",
                username = "tk01234",
                password = "123456",
                workingDate = "24/11/2022",
                priority = "1"
            });
            accounts.Add(new Account
            {
                sttTK = 3,
                employeeCode = "NV03",
                employeeName = "Nguyễn Văn C",
                employeePhone = "0123456789",
                avatarTK = "/Accounts/AccountAvatar/avatar3.jpg",
                username = "tk012345",
                password = "123456",
                workingDate = "24/11/2022",
                priority = "1"
            });
            accounts.Add(new Account
            {
                sttTK = 4,
                employeeCode = "NV04",
                employeeName = "Nguyễn Văn D",
                employeePhone = "0123456789",
                avatarTK = "/Accounts/AccountAvatar/avatar1.jpg",
                username = "tk012432",
                password = "123456",
                workingDate = "24/11/2022",
                priority = "1"
            });

            view = new Resources.PagingCollectionView(accounts, 2);

            this.DataContext = view;
            accountsDataGrid.ItemsSource = view;
        }

        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccountForm accountForm = new AddAccountForm();
            accountForm.ShowDialog();
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm();
            editAccountForm.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ViewAccountDetails viewAccount = new ViewAccountDetails();
            viewAccount.ShowDialog();
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
