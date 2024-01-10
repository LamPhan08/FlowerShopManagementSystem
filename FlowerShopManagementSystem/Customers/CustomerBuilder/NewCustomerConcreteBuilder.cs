using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Customers.CustomerBuilder
{
    public class NewCustomerConcreteBuilder : NewCustomerBuilder
    {
        public string name;
        public string address;
        public string phone;
        public string ngayDK;
        public string doanhSo;
        public NewCustomerBuilder setName(string name)
        {
            this.name = name;
            return this;
        }
        public NewCustomerBuilder setAddress(string address)
        {
            this.address = address;
            return this;
        }
        public NewCustomerBuilder setPhone(string phone)
        {
            this.phone = phone;
            return this;
        }
        public NewCustomerBuilder setNgayDK(string ngayDK)
        {
            this.ngayDK = ngayDK;
            return this;
        }
        public NewCustomerBuilder setDoanhSo(string doanhSo)
        {
            this.doanhSo = doanhSo;
            return this;
        }
        public NewCustomer build()
        {
            return new NewCustomer(name, address, phone, ngayDK, doanhSo);
        }
    }
}
