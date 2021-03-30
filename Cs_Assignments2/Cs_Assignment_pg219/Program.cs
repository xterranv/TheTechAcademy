using System;

namespace Cs_Assignment_pg219
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("INT: 50 + 5 equals: " + MathClass.MathAdd(5));
            Console.WriteLine("DOUBLE: 175 + 5.55 equals: " + MathClass.MathAdd(5.55));
            Console.WriteLine("Results is: " + MathClass.MathAdd("10"));

            Console.ReadLine();
        }
    }
}
