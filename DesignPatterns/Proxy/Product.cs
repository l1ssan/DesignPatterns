using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Product
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Text { get; set; }
    }

    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }


}
