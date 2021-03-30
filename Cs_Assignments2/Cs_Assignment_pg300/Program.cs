using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg300
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDt = DateTime.Now;
            Console.WriteLine($"The current date and time is: {currentDt}");

            Console.WriteLine();
            Console.WriteLine("Please enter a number");
            int nbr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine(DateTime.Now.AddHours(nbr));

            Console.ReadLine();
        }
    }
}
