using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //&& AND boolean operator - Are BOTH of these True
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.WriteLine();

            //|| OR boolean operator - Are One of these True
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);
            Console.WriteLine();

            //== EQUAL boolean operator
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);
            Console.WriteLine();

            //!= DOES NOT EQUAL boolean operator
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);
            Console.WriteLine();

            //^ XOR boolean operator - Is One true but Not both
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.WriteLine();

            //Combination of operators
            Console.WriteLine(true && true && true && false);
            Console.WriteLine(true && true && true || false);
            
            Console.ReadLine();
        }
    }
}
