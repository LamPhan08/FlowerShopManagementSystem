using System;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows;
using FlowerShopManagementSystem.Accounts.StrategyForAccount_ErrorHandling;

namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD
{
    internal class EditAccountStrategy : IAccountStrategy
    {
        private EditAccountForm _form;
        IErrorHandlingStrategy errorHandlingStrategy;
        public EditAccountStrategy(EditAccountForm form)
        {
            _form = form;
            errorHandlingStrategy = new DefaultErrorHandlingStrategy(); // Set a default strategy
        }
        public void Execute(Account updatedAccount, string updatedImage, string imageName)
        {
            try
            {
                updatedAccount = new Account();
                updatedAccount.employeeCode = _form.tbxEditEmployeeID.Text.ToString();
                updatedAccount.employeeName = _form.tbxEditEmployeeName.Text.ToString();
                updatedAccount.employeePhone = _form.tbxEditEmployeePhoneNumber.Text.ToString();
                updatedAccount.workingDate = _form.dpkEditWorkingDate.Text.ToString();
                updatedAccount.username = _form.tbxEditUsername.Text.ToString();
                updatedAccount.password = _form.tbxEditPassword.Text.ToString();
                if (updatedImage != "")
                {
                    imageName = System.IO.Path.GetFileName(updatedImage);
                    updatedAccount.avatarTK = imageName;
                    if (!System.IO.File.Exists("../../Accounts/AccountAvatar/" + imageName))
                    {
                        System.IO.File.Copy(updatedImage, "../../Accounts/AccountAvatar/" + imageName);
                    }
                }
                ComboBoxItem priorityCBI = (ComboBoxItem)_form.cbbEditAccountPriority.SelectedItem;
                if (priorityCBI.Content.ToString() == "Manager")
                {
                    updatedAccount.priority = "1";
                }
                else
                {
                    updatedAccount.priority = "0";
                }
                //if (updatedAccount.avatarTK != AccountsView.accountOldInfo.avatarTK)
                //{
                //    using (var sqlConnection = new SqlConnection(Database.connection))
                //    using (var cmd = new SqlDataAdapter())
                //    using (var insertCommand = new SqlCommand(
                //        "update NHAN_VIEN " +
                //        "set HOTEN = '" + updatedAccount.employeeName + "', SODT = '" + updatedAccount.employeePhone + "', NGVL = '" + updatedAccount.workingDate + "', USERNAME = '" + updatedAccount.username + "', USER_PASSWORD = '" + updatedAccount.password + "', USER_PRIORITY = '" + updatedAccount.priority + "', AVATAR = '" + updatedAccount.avatarTK + "' " +
                //        "where MANV = '" + updatedAccount.employeeCode + "'"))
                //    {
                //        insertCommand.Connection = sqlConnection;
                //        cmd.InsertCommand = insertCommand;
                //        sqlConnection.Open();
                //        cmd.InsertCommand.ExecuteNonQuery();
                //    }
                //}
                //else
                //{
                //    using (var sqlConnection = new SqlConnection(Database.connection))
                //    using (var cmd = new SqlDataAdapter())
                //    using (var insertCommand = new SqlCommand(
                //        "update NHAN_VIEN " +
                //        "set HOTEN = '" + updatedAccount.employeeName + "', SODT = '" + updatedAccount.employeePhone + "', NGVL = '" + updatedAccount.workingDate + "', USERNAME = '" + updatedAccount.username + "', USER_PASSWORD = '" + updatedAccount.password + "', USER_PRIORITY = '" + updatedAccount.priority + "' " +
                //        "where MANV = '" + updatedAccount.employeeCode + "'"))
                //    {
                //        insertCommand.Connection = sqlConnection;
                //        cmd.InsertCommand = insertCommand;
                //        sqlConnection.Open();
                //        cmd.InsertCommand.ExecuteNonQuery();
                //    }
                //}
                using (var sqlConnection = new SqlConnection(Database.connection))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand(
                    "update NHAN_VIEN " +
                    "set HOTEN = '" + updatedAccount.employeeName + "', SODT = '" + updatedAccount.employeePhone + "', NGVL = '" + updatedAccount.workingDate + "', USERNAME = '" + updatedAccount.username + "', USER_PASSWORD = '" + updatedAccount.password + "', USER_PRIORITY = '" + updatedAccount.priority + "', AVATAR = '" + updatedAccount.avatarTK + "' " +
                    "where MANV = '" + updatedAccount.employeeCode + "'"))
                {
                    insertCommand.Connection = sqlConnection;
                    cmd.InsertCommand = insertCommand;
                    sqlConnection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Done!", "Message:", MessageBoxButton.OK, MessageBoxImage.Information);
                _form.Close();
            }
            catch (Exception ex)
            {
                if (_form.tbxEditEmployeeID.Text.Length < 5 || _form.tbxEditEmployeeID.Text.Length > 5)
                {
                    SetErrorHandlingStrategy(new EmployeeIDLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxEditEmployeeName.Text.Length > 40)
                {
                    SetErrorHandlingStrategy(new EmployeeNameLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxEditEmployeePhoneNumber.Text.Length < 10 || _form.tbxEditEmployeePhoneNumber.Text.Length > 11)
                {
                    SetErrorHandlingStrategy(new EmployeePhoneNumberLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxEditUsername.Text.Length > 50)
                {
                    SetErrorHandlingStrategy(new EmployeeUsernameLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxEditPassword.Text.Length > 50)
                {
                    SetErrorHandlingStrategy(new EmployeePasswordLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (imageName.Length > 100)
                {
                    SetErrorHandlingStrategy(new EmployeeImageNameLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                else
                {
                    SetErrorHandlingStrategy(new DefaultErrorHandlingStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
            }
        }
        // Introduce a method to set the error-handling strategy dynamically
        private void SetErrorHandlingStrategy(IErrorHandlingStrategy newStrategy)
        {
            errorHandlingStrategy = newStrategy;
        }
    }
}
