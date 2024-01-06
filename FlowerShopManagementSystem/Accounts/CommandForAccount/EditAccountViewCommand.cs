using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Accounts.CommandForAccount
{
    public class EditAccountViewCommand : IAccountViewCommand
    {
        private AccountsView _accountsView;
        public static Account accountOldInfo;
        public EditAccountViewCommand(AccountsView accountsView)
        {
            _accountsView = accountsView;
        }
        public void Execute()
        {
            // Logic to add an account
            EditAccountForm accountForm = new EditAccountForm();
            //accountForm.tbxEditPassword.Text = _accountsView.generator.GeneratePassword();
            //accountForm.ShowDialog();
            //_accountsView.ReloadData(_accountsView.accounts);
            accountOldInfo = (Account)_accountsView.accountsDataGrid.SelectedItem;
            string employeeID = accountOldInfo.employeeCode.Trim(),
                    employeeName = accountOldInfo.employeeName.Trim(),
                    employeePhoneNumber = accountOldInfo.employeePhone.Trim(),
                    employeeWorkingDate = accountOldInfo.workingDate.Trim(),
                    employeeUsername = accountOldInfo.username.Trim(),
                    employeePassword = accountOldInfo.password.Trim();
            string employeeAvatar = accountOldInfo.avatarTK.Trim();
            string[] imageNameParts = employeeAvatar.Split('/');
            string employeePriority = accountOldInfo.priority;
            accountForm.tbxEditEmployeeID.Text = employeeID;
            accountForm.tbxEditEmployeeName.Text = employeeName;
            accountForm.tbxEditEmployeePhoneNumber.Text = employeePhoneNumber;
            accountForm.dpkEditWorkingDate.Text = employeeWorkingDate;
            accountForm.tbxEditUsername.Text = employeeUsername;
            accountForm.tbxEditPassword.Text = employeePassword;
            accountForm.editavatar.ImageSource = new BitmapImage(new Uri(@"../../Accounts/AccountAvatar/" + imageNameParts[imageNameParts.Length - 1], UriKind.Relative));
            if (employeePriority == "0")
            {
                accountForm.cbbEditAccountPriority.Text = "Employee";
            }
            else
            {
                accountForm.cbbEditAccountPriority.Text = "Manager";
            }
            accountForm.ShowDialog();
            _accountsView.ReloadData(_accountsView.accounts);
        }
    }
}
