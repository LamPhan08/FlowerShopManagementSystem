using System;

namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_ErrorHandling
{
    internal interface IErrorHandlingStrategy
    {
        void HandleError(Exception ex);
    }
}
