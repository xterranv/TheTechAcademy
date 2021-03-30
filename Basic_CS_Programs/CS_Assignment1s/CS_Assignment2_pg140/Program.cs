using System;

namespace CS_Assignment2_pg140
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Add two numbers:");
            int addNbr1 = 5;
            int addNbr2 = 15;
            int addTotal = addNbr1 + addNbr2;
            Console.WriteLine("5 + 15 = " + addTotal);
            Console.WriteLine("");

            Console.WriteLine("Subtract two numbers:");
            int subtrNbr1 = 15;
            int subtrNbr2 = 5;
            int subtrTotal = subtrNbr1 - subtrNbr2;
            Console.WriteLine("15 - 5 = " + subtrTotal);
            Console.WriteLine("");

            Console.WriteLine("Multiply two numbers:");
            int timesNbr1 = 5;
            int timesNbr2 = 15;
            int timesTotal = timesNbr1 * timesNbr2;
            Console.WriteLine("5 * 15 = " + timesTotal);
            Console.WriteLine("");

            Console.WriteLine("Divide two numbers: ");
            int divideNbr1 = 15;
            int divideNbr2 = 5;
            int divideTotal = divideNbr1 / divideNbr2;
            Console.WriteLine("15 / 5 = " + divideTotal);

            Console.ReadLine();
        }
    }
}
