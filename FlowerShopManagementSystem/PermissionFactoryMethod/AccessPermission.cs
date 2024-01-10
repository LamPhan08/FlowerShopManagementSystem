using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.PermissionFactoryMethod
{
    public interface AccessPermission
    {
        void SetPermissions(MainWindow mainWindow);
    }
}
