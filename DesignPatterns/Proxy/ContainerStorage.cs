using System.Linq;

namespace DesignPatterns.Proxy
{
    public class ContainerStorage : IContainer
    {
        ProductContext database;

        public ContainerStorage()
        {
            //work with ef just change your pc name and add some records  
            string constring = "Data Source=USER-PC;Initial Catalog=proxycheckdb;Integrated Security=True";
            database = new ProductContext(constring);
        }


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
