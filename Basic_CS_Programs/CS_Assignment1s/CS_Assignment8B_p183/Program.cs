using System;

namespace CS_Assignment8B_p813
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Click Enter to start a count to 15.");
            Console.ReadLine();

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 16);

            Console.WriteLine("");
            Console.WriteLine("The End!! Have a great day!!");
            Console.ReadLine();
        }
    }
}
