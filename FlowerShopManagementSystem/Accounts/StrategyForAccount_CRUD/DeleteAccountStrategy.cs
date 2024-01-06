using FlowerShopManagementSystem.NotificationBox;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD
{
    public class DeleteAccountStrategy : IAccountStrategy
    {
        AccountsView _accountsView;
        public DeleteAccountStrategy(AccountsView accountsView)
        {
            _accountsView = accountsView;
        }

        public void Execute(Account account, string image, string imageName)
        {
            // Logic to delete an account
            DeleteConfirmationBox deleteConfirmationBox = new DeleteConfirmationBox();
            deleteConfirmationBox.ShowDialog();
            if (DeleteConfirmationBox.isDeleteBtnClicked)
            {
                try
                {
                    //Account account = (Account)_accountsView.accountsDataGrid.SelectedItem;
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
        }
    }
}
