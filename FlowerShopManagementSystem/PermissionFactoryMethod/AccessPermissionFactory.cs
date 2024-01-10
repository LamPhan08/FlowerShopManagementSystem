using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.PermissionFactoryMethod
{
    public class AccessPermissionFactory
    {
        public static AccessPermission CreateAccessPermission(int priority)
        {
            if (priority == 1)
            {
                return new ManagerAccess();
            }
            else
            {
                return new EmployeeAccess();
            }
        }
    }
}
