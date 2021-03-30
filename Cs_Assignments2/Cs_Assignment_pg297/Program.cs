using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cs_Assignment_pg297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string urNbr = Console.ReadLine();            
            File.WriteAllText(@"c:\users\xterr\desktop\log.txt", urNbr);
            Console.WriteLine();
            string txtRead = File.ReadAllText(@"c:\users\xterr\desktop\log.txt");
            Console.WriteLine($"The number in the log file read back to you is: {txtRead}");

            Console.ReadLine();
        }
    }
}
