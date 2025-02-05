using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Objektumok összehasonlítását teszi lehetővé egyedi rendezési logikával.
Az Compare metódust implementálja.
Gyakran használják listák vagy tömbök rendezésére egyedi logikával.
*/

namespace ComparerInterface
{
    // Minta osztály
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    // Összehasonlítás az ár alapján
    public class PriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    class ComparProg
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
        {
            new Product { Name = "Alma", Price = 10 },
            new Product { Name = "Barack", Price = 5 },
            new Product { Name = "Cseresznye", Price = 15 }
        };

            // A rendezés metódusa a PriceComparer osztály Compare metódusát használja
            products.Sort(new PriceComparer());

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}: {product.Price}");
            }

            Console.ReadKey();
        }
    }
}
