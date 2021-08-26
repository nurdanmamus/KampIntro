using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperation = new FourOperations();
            fourOperation.Add(2, 3);

            int number1 = 20;
            int number2 = 100; 
            //number1 in değeri fonksiyona gider. kendisi değil!  
            //örneğin kredi oranı müşteri göre değişecekse, fonksiyona girince ref ile değiştirebiliriz.
            int result = fourOperation.Add2(ref number1, number2);   
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
