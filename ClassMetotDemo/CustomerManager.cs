using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is added.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is deleted.");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Customers are listed");
        } 
    }
}
