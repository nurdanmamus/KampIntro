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
            Console.ReadKey();
        }
    }
}
