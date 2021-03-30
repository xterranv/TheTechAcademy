using System;

namespace CS_Assignment4_pg151
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1.(MULTIPLY by 50): Please Enter a number: ");
            long times = Convert.ToInt64(Console.ReadLine()) * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + times);
            Console.WriteLine("");

            Console.WriteLine("2. (ADD 25): Please Enter another number: ");
            int adds = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine("Your number plus 25 is: " + adds);
            Console.WriteLine("");

            Console.WriteLine("3. (DIVIDE BY 12.5): Please Enter another number: ");
            double quotient = Convert.ToInt32(Console.ReadLine()) / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.WriteLine("");

            Console.WriteLine("4. (GREATER THAN 50?): Please Enter another number: ");
            int userNbr = Convert.ToInt32(Console.ReadLine());
            bool isGreater = userNbr > 50;
            Console.WriteLine("Is your number greater than 50? " + isGreater);
            Console.WriteLine("");

            Console.WriteLine("5. (IS THERE A REMAINDER?): Please Enter another number: ");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("Is there a remainder? " + remainder);
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}