using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg221
{
    class VoidMethod
    {
        public static void MyParams(int x, out int y)
        {
            x = x + 25;
            Console.WriteLine("x is equal to {0}: ", x);
            
            y = 571;
            Console.WriteLine($"y is equal to {y}");

            return;          
        }
    }
}
