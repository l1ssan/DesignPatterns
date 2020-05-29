using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public interface IGetFromType
    {
        void GetAllProducts(Product[] prods);
    }
}
