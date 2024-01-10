using System;
using System.Windows;

namespace FlowerShopManagementSystem.Accounts.StrategyForAccount_ErrorHandling
{
    public class DefaultErrorHandlingStrategy: IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            // Default error-handling logic
            MessageBox.Show($"Error: {ex.Message}", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class EmployeeIDLengthErrorStrategy : IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            MessageBox.Show("Error:\nEmployee ID must have exactly 5 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class EmployeeNameLengthErrorStrategy : IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            MessageBox.Show("Error:\nEmployee's name must not have more than 40 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class EmployeePhoneNumberLengthErrorStrategy : IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            MessageBox.Show("Error:\nEmployee ID must not have more than 11 characters, or less than 10 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class EmployeeUsernameLengthErrorStrategy : IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            MessageBox.Show("Error:\nEmployee's username must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class EmployeePasswordLengthErrorStrategy : IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            MessageBox.Show("Error:\nEmployee's password must not have more than 50 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class EmployeeImageNameLengthErrorStrategy : IErrorHandlingStrategy
    {
        public void HandleError(Exception ex)
        {
            MessageBox.Show("Error:\nImage's name must not have more than 100 characters!", "Error alert!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
