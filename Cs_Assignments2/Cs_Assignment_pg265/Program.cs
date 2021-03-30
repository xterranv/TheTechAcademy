using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg265
{
    class Program
    {
        int empID { get; set; }
        string fname { get; set; }
        string lname { get; set; }

        static void Main(string[] args)
        {
            var names = new List<Program>
            {
                new Program { empID = 1, fname = "Joe", lname = "Smith" },
                new Program { empID = 2, fname = "Mary", lname = "Townsend"},
                new Program { empID = 3, fname = "Peter", lname = "Samuel"},
                new Program { empID = 4, fname = "Joe", lname = "Taylor"},
                new Program { empID = 5, fname = "Martin", lname = "Gayle"},
                new Program { empID = 6, fname = "Sara", lname = "Jones" },
                new Program { empID = 7, fname = "Heidi", lname = "Miller"},
                new Program { empID = 8, fname = "Joel", lname = "Feinstein"},
                new Program { empID = 9, fname = "Joelle", lname = "Marks"},
                new Program { empID = 10, fname = "Mike", lname = "Johnson"},
            };
            var newList = names.Where(x => x.fname == "Joe").ToList();
            foreach (var result in newList)
            {                
                Console.WriteLine($"Employee ID: {result.empID} -- Full Name: {result.fname} {result.lname}");
                
            }
            Console.WriteLine();

            List<Program> lists = names.Where(i => i.empID > 5).ToList();           

            foreach (var values in lists)
            {
                Console.WriteLine($"Employee ID: {values.empID} -- Full Name: {values.fname} {values.lname}");
            }


            Console.ReadLine();
        }
    }
}