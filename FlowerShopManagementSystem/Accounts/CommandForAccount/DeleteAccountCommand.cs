using FlowerShopManagementSystem.NotificationBox;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.Accounts.CommandForAccount
{
    public class DeleteAccountCommand : IAccountViewCommand
    {
        private AccountsView _accountsView;

        public DeleteAccountCommand(AccountsView accountsView)
        {
            _accountsView = accountsView;
        }
        public void Execute()
        {
            // Logic to delete an account
            DeleteConfirmationBox deleteConfirmationBox = new DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
            if (DeleteConfirmationBox.isDeleteBtnClicked)
            {
                try
                {
                    Account account = (Account)_accountsView.accountsDataGrid.SelectedItem;
                    // Implement database deletion logic
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
            _accountsView.ReloadData(_accountsView.accounts);
        }
    }
}
