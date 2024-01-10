using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Orders.OrderState
{
    public interface IOrderState
    {
        void PrintInvoice(ViewOrder viewOrder, HOA_DON order);
        void HandlePayment(ViewOrder viewOrder, HOA_DON order);
    }
}
