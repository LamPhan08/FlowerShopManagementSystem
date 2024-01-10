using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Accounts.CommandForAccount
{
    public class AccountInvoker
    {
        private IAccountViewCommand viewAddAccountFormCommand;
        private IAccountViewCommand viewEditAccountFormCommand;
        public AccountInvoker(IAccountViewCommand viewAddAccountFormCommand, IAccountViewCommand viewEditAccountFormCommand)
        {
            this.viewAddAccountFormCommand = viewAddAccountFormCommand;
            this.viewEditAccountFormCommand = viewEditAccountFormCommand;
        }
        public void viewAddAccountForm()
        {
            viewAddAccountFormCommand.Execute();
        }
        public void viewEditAccountForm()
        {
            viewEditAccountFormCommand.Execute();
        }
    }
}
