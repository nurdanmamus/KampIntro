using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "apple";
            product1.ProductPrice = 15;
            product1.ProductDescription = "gold apple";

            Product product2 = new Product();
            product2.ProductName = "banana";
            product2.ProductPrice = 10; 
            product2.ProductDescription = "gold banana";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products) 
            {
                Console.WriteLine(product.ProductName); 
            }

            CardManager cardManager = new CardManager();
            cardManager.Add(product1); 

            Console.ReadKey(); 
        }
    }
}
