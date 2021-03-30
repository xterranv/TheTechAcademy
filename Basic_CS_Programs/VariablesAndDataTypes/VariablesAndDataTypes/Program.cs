using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Your name is " + name + "!");
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favNumber = Console.ReadLine();
            int favNbr = Convert.ToInt32(favNumber);
            int total = favNbr + 5;
            Console.WriteLine("Your Favorite number is plus 5 is: " + total);
            Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
        }
    }
}
