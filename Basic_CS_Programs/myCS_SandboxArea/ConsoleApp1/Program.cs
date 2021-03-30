using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //have one list with values, and go thru the list to find all names NOT equal to "MATT"
            //Then add those to a NEW LIST
            //Second Foreach loop iterates through the new matchNames list and prints all the names in the list

            List<string> names = new List<string>() { "Matt", "Brian", "Mike", "Peter", "Matt" };
            List<string> matchNames = new List<string>();

            foreach (string name in names)
            {
                if (name != "Matt" )
                {
                    matchNames.Add(name);
                }
            }

            foreach (string matchedName in matchNames)
            {
                Console.WriteLine(matchedName);
            }

            Console.ReadLine();
        }
    }
}
