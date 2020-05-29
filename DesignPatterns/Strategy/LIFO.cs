using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class LIFO : IGetFromType
    {

        public void GetAllProducts(Product[] prods)
        {
            var orderProds = prods.OrderByDescending(item => item.Id);

            foreach (var item in orderProds)
            {
                Console.WriteLine($"Get prods Id {item.Id} Name {item.Name} Qty {item.Qty} Place {item.Place}");
            }
        }
    }
}
