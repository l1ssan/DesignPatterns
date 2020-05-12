using System.Linq;

namespace DesignPatterns.Proxy
{
    public class ContainerStorage : IContainer
    {
        ProductContext database = new ProductContext();

        public void Dispose()
        {
            database.Dispose();
        }

        public Product GetProduct(string number)
        {
            return database.Products.FirstOrDefault(item => item.Number == number);
        }
    }
}
