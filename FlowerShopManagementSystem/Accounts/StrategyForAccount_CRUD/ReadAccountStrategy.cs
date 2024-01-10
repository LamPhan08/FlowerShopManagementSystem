using System;
using System.Windows.Media.Imaging;

namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD
{
    public class ReadAccountStrategy : IAccountStrategy
    {
        public void Execute(Account account, string image, string imageName)
        {
            ViewAccountDetails viewAccount = new ViewAccountDetails();
            //Account selectedAccount = (Account)accountsDataGrid.SelectedItem as Account;
            viewAccount.txtblckEmployeeID.Text = account.employeeCode;
            viewAccount.txtblckEmployeeName.Text = account.employeeName;
            viewAccount.txtblckEmployeePhone.Text = account.employeePhone;
            viewAccount.txtblckWorkingDate.Text = account.workingDate;
            viewAccount.txtblckUsername.Text = account.username;
            viewAccount.txtblckPassword.Text = account.password;
            string employeeAvatar = account.avatarTK.Trim();
            string[] imageParts = employeeAvatar.Split('/');
            viewAccount.avatarIB.ImageSource = new BitmapImage(new Uri(@"../../Accounts/AccountAvatar/" + imageParts[imageParts.Length - 1], UriKind.Relative));
            if (account.priority == "0")
            {
                viewAccount.txtblckPriority.Text = "Employee";
            }
            else
            {
                viewAccount.txtblckPriority.Text = "Manager";
            }
            viewAccount.ShowDialog();
        }
    }
}
