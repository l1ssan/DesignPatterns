using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Warehouse
    {

        public Product[] Products { get; set; }
        public IGetFromType GetFromType { private get; set; }

        public Warehouse(Product[] prods, IGetFromType getFromType)
        {
            Products = prods;
            GetFromType = getFromType;
        }

        public void GetAllProduct()
        {
            GetFromType.GetAllProducts(Products);
        }



    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Qty { get; set; }

        public string Place { get; set; }
    }

}
