using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total + othertotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double divide = 100.0 / 17.0;
            //Console.WriteLine(divide);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();
            ////a result of 0 means no remainder
            ////a result of 1 means there is a remainder

            //comparison operator
            //bool truOrFalse = 12 < 5;
            //Console.WriteLine(truOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;
            //bool isWarm = currentTemp > roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 70;

            //bool isWarm = currentTemp <= roomTemp;
            bool isWarm = currentTemp != roomTemp;

            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
