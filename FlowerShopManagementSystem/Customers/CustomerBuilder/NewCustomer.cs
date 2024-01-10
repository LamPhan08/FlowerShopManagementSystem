using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Customers.CustomerBuilder
{
    public class NewCustomer
    {
        public string name;
        public string address;
        public string phone;
        public string ngayDK;
        public string doanhSo;
        public NewCustomer(string name, string address, string phone, string ngayDK, string doanhSo)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.ngayDK = ngayDK;
            this.doanhSo = doanhSo;
        }
    }
}
