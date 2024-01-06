using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Suppliers.StrategyForSupplier_CRUD
{
    public interface ISupplierStrategy
    {
        void Execute(Supplier supplier);
    }
}
