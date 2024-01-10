using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShopManagementSystem.PermissionFactoryMethod
{
    public class EmployeeAccess : AccessPermission
    {
        public void SetPermissions(MainWindow mainWindow)
        {
            mainWindow.btnAccounts.Visibility = Visibility.Collapsed;
            mainWindow.btnSuppliers.Visibility = Visibility.Collapsed;
            mainWindow.btnProducts.Visibility = Visibility.Collapsed;
            mainWindow.btnStatistics.Visibility = Visibility.Collapsed;
        }
    }
}
