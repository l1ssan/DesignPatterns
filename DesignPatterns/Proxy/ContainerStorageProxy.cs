using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ContainerStorageProxy : IContainer
    {
        private List<Product> products = new List<Product>();

        ContainerStorage containerStorage;

        public ContainerStorageProxy()
        {
        }

        public Product GetProduct(string number)
        {
            Product prod = products.FirstOrDefault(item => item.Number == number);
            if (prod == null)
            {
                if (containerStorage == null)
                {
                    containerStorage = new ContainerStorage();
                }

                prod = containerStorage.GetProduct(number);
                products.Add(prod);
            }
            return prod;
        }

        public void Dispose()
        {
            if (containerStorage != null)
                containerStorage.Dispose();
        }


    }
}
