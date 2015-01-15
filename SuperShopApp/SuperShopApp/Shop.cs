using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }

        private List<Product> products;

        public Product[] GetProducts()
        {
            return products.ToArray();
        }

        public Shop()
        {
            products = new List<Product>();
        }

        public string AddProduct(Product productToBeAdded)
        {
            foreach (Product existingProduct in products)
            {
                if (existingProduct.Id == productToBeAdded.Id)
                {
                    existingProduct.Quantity += productToBeAdded.Quantity;
                    return "Updated";
                }
            }

            products.Add(productToBeAdded);
            return "Added";
        }

    }
}
