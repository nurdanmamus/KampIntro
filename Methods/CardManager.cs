using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CardManager
    { 
        public void Add(Product product)  
        {
            Console.WriteLine("Sepete eklendi." + product.ProductName); 
        }

        //false , encapsulation
        public void Add2(string productName, string productDescription, double productPrice)
        {
            Console.WriteLine("Sepete eklendi." + productName); 
        } 
    }
}
