using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Customers.CustomerBuilder
{
    public interface NewCustomerBuilder
    {
        NewCustomerBuilder setName(string name);
        NewCustomerBuilder setAddress(string address);
        NewCustomerBuilder setPhone(string phone);
        NewCustomerBuilder setNgayDK(string ngayDK);
        NewCustomerBuilder setDoanhSo(string doanhSo);
        NewCustomer build();
    }
}
