using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg310
{
    public class Sale
    {        
        public Sale(string salesman) : this(salesman, 9500)
        {
        }
        public Sale(string salesman, int amount)
        {
            Name = salesman;
            Invoice = amount;
            Console.WriteLine("\nSale Details:\n Salesman: {0}, Invoice Total: {1}", Name, Invoice);
        }

        public string Name { get; set; }
        public int Invoice { get; set; }
    }
}
