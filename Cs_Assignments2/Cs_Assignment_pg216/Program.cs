using System;

namespace Cs_Assignments_pg216
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Math with the number 25\n");
            Console.WriteLine("Enter a number: ");
            int myNbr = Convert.ToInt32(Console.ReadLine());
            int x = myNbr;

            Console.WriteLine($"25 + {myNbr} equals: " + MyMathClass.MyAddition(myNbr));
            Console.WriteLine($"25 - {myNbr} equals: " + MyMathClass.MySubtraction(myNbr));
            Console.WriteLine($"25 * {myNbr} equals: " + MyMathClass.MyMultiply(myNbr));

            Console.ReadLine();
        }
    }
}

