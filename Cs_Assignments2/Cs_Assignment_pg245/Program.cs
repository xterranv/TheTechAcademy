using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg245
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee();
            worker1.EmpID = 057;
            worker1.FirstName = "Joe";
            worker1.LastName = "Worker";
            worker1.GetID();
            worker1.SayName();
            Console.WriteLine();

            Employee worker2 = new Employee();
            worker2.EmpID = 537;
            worker2.FirstName = "John";
            worker2.LastName = "Jones";
            worker2.GetID();
            worker2.SayName();
            Console.WriteLine();

            if (worker1 == worker2)
                Console.WriteLine($"ID {worker1.EmpID} equals ID {worker2.EmpID}");

            else
                Console.WriteLine($"ID {worker1.EmpID} does not equal ID {worker2.EmpID}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
