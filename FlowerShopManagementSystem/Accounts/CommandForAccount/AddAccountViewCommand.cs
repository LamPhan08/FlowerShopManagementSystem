using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Accounts.CommandForAccount
{
    public class AddAccountViewCommand : IAccountViewCommand
    {
        private AccountReceiver account;
        public AddAccountViewCommand(AccountReceiver account)
        {
            this.account = account;
        }
        public void Execute()
        {
            account.openAddAccountForm();
        }
    }
}
