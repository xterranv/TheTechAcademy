using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg221
{
    class Program
    {
        public static void Main(string[] args)
        {
            int myNbr = 50;
            int result;            

            Console.WriteLine(myNbr + " + 25 = x");
            Console.WriteLine("");

            VoidMethod.MyParams(x: myNbr, y: out result);

            Console.ReadLine();
        }

    }
}