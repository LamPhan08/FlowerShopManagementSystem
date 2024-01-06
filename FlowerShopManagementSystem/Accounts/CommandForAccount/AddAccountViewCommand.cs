using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Accounts.CommandForAccount
{
    public class AddAccountViewCommand : IAccountViewCommand
    {
        private AccountsView _accountsView;
        public AddAccountViewCommand(AccountsView accountsView)
        {
            _accountsView = accountsView;
        }
        public void Execute()
        {
            // Logic to add an account
            AddAccountForm accountForm = new AddAccountForm();
            accountForm.tbxPassword.Text = _accountsView.generator.GeneratePassword();
            accountForm.ShowDialog();
            _accountsView.ReloadData(_accountsView.accounts);
        }
    }
}
