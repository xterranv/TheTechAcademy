using System;

namespace CS_Assignment8_p183
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Click Enter to start a count to 25.");
            Console.ReadLine();

            int i = 0;
            while (i < 26)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("That's all Folks.  Have a great day!!");
            Console.ReadLine();
        }
    }
}
