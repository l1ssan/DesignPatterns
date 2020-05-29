using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class FIFO : IGetFromType
    {
        public void GetAllProducts(Product[] prods)
        {
            var orderProds = prods.OrderBy(item => item.Id);

            foreach (var item in orderProds)
            {
                Console.WriteLine($"Get prods Id {item.Id} Name {item.Name} Qty {item.Qty} Place {item.Place}");
            }
        }
    }
}
