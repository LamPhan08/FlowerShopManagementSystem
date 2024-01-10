using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopManagementSystem.Products.ProductMementor
{
    public class ProductMemento
    {
        public List<Product> ProductsSnapshot { get; }

        public ProductMemento(List<Product> products)
        {
            ProductsSnapshot = new List<Product>(products);
        }
    }
}
