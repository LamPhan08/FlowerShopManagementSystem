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
        private AccountReceiver account;
        public EditAccountViewCommand(AccountReceiver account)
        {
            this.account = account;
        }
        public void Execute()
        {
            account.openEditAccountForm();
        }
    }
}
