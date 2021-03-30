using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg248
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Susan";
            employee.LastName = "Thomas";
            employee.SayName();            
            Console.WriteLine();

            Employee<string> employeeItems = new Employee<string>();
            employeeItems.Things = new List<string>() { "Desk","Phone","Laptop","Monitors" };

            Employee<int> employeeRatings = new Employee<int>();
            employeeRatings.Things = new List<int>() { 5, 4, 5, 3 };

            Console.WriteLine("Office items: ");
            foreach (string items in employeeItems.Things )
            {
                Console.WriteLine(items);
            }

            Console.WriteLine();
            Console.WriteLine("Customer Ratings: ");
            foreach (int values in employeeRatings.Things)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
