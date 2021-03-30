using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_240
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            //employee.Quit();
            Console.WriteLine();

            //Create an IQuittable Object can call the Quit() method
            IQuittable name = new Employee();
            name.FirstName = "Joe";
            name.LastName = "Worker";
            name.Quit();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
