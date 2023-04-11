using Newtonsoft.Json;
using System.Text.Json;

namespace JSONReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pathToDirectory = @"path";

            Func<Product, bool> filter = p => p.Price > 50 && p.Category == "Electronics";

            for (int i = 1; i <= 10; i++)
            {
                string filePath = Path.Combine(pathToDirectory, $"{i}.json");

                var products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(filePath));
                List<Product> filteredProducts = products.Where(filter).ToList();
                filteredProducts.ForEach(p => Console.WriteLine(p.Name));
            }
        }
    }
}