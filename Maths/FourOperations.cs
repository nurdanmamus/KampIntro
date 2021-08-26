using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class FourOperations
    {
        public void Add(int sayi1, int sayi2) { 
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " + toplam); 
        } 

        public int Add2(ref int number1 = 20, int number2=30)    
        {
            number1 = 10; 
            return number1 + number2; 
        }

        static int Add3(int number1, int number2)
        {
            number1 = 10;
            return number1 + number2;
        }

        //overloading
        static int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiple(int number1, int number2, int number3)
        {
            return number1 * number2 * number3; 
        }

        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
