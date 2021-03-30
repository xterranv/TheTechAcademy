using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example
{
    class Program
    {
        static void Main()
        {
            //Specifies the Data Source
            string[] students = new string[]
            {
                "Lacey", "Tricia", "Gavin", "Josh","Jon","Landon","Kyndreshia"
            };

            //Defines the query expression
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 6
                select student;

            //Executes the query
            foreach (string s in studentQuery)
            {
                Console.Write(s + " ");
            }
            Console.ReadLine();
        }
    }
}
