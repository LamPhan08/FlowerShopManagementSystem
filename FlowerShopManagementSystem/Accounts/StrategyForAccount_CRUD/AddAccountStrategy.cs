using FlowerShopManagementSystem.Accounts.StrategyForAccount_ErrorHandling;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD
{
    internal class AddAccountStrategy : IAccountStrategy
    {
        AccountsView accountsView;
        private AddAccountForm _form;
        IErrorHandlingStrategy errorHandlingStrategy;
        public AddAccountStrategy(AddAccountForm form)
        {
            _form = form;
            errorHandlingStrategy = new DefaultErrorHandlingStrategy(); // Set a default strategy
        }
        public void Execute(Account account, string image, string imageName)
        {
            try
            {
                account = new Account();
                accountsView = new AccountsView();
                account.employeeCode = _form.tbxEmployeeID.Text.ToString();
                account.employeeName = _form.tbxEmployeeName.Text.ToString();
                account.employeePhone = _form.tbxEmployeePhoneNumber.Text.ToString();
                account.workingDate = _form.dpkWorkingDate.Text.ToString();
                account.username = _form.tbxUsername.Text.ToString();
                account.password = _form.tbxPassword.Text.ToString();
                if (image != "")
                {
                    imageName = System.IO.Path.GetFileName(image);
                    account.avatarTK = imageName;
                    if (!System.IO.File.Exists("../../Accounts/AccountAvatar/" + imageName))
                    {
                        System.IO.File.Copy(image, "../../Accounts/AccountAvatar/" + imageName);
                    }
                }
                if (_form.cbbAccountPriority.Text.ToString() == "Manager")
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
                _form.Close();
            }
            catch (Exception ex)
            {
                if (_form.tbxEmployeeID.Text.Length < 5 || _form.tbxEmployeeID.Text.Length > 5)
                {
                    SetErrorHandlingStrategy(new EmployeeIDLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxEmployeeName.Text.Length > 40)
                {
                    SetErrorHandlingStrategy(new EmployeeNameLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxEmployeePhoneNumber.Text.Length < 10 || _form.tbxEmployeePhoneNumber.Text.Length > 11)
                {
                    SetErrorHandlingStrategy(new EmployeePhoneNumberLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxUsername.Text.Length > 50)
                {
                    SetErrorHandlingStrategy(new EmployeeUsernameLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (_form.tbxPassword.Text.Length > 50)
                {
                    SetErrorHandlingStrategy(new EmployeePasswordLengthErrorStrategy());
                    errorHandlingStrategy.HandleError(ex);
                }
                if (imageName.Length > 100)
                {
                    SetErrorHandlingStrategy(new EmployeeImageNameLengthErrorStrategy());
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
