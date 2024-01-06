namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_CRUD
{
    public interface IAccountStrategy
    {
        void Execute(Account account, string image, string imageName);
    }
}
