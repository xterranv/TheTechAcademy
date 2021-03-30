using System;

namespace CS_Assignment7_p178
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");
            Console.WriteLine("What is the Weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("The package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the package Width?");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package Height?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package Length?");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((height + length + width) > 50)
                {
                    Console.WriteLine("The Package is too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    int product = (height * width * length) * weight;
                    int total = product / 100;

                    Console.WriteLine("");
                    Console.WriteLine("Your estimated total for shipping this package is: " + total.ToString("C"));
                    Console.WriteLine("Thank You!");
                }
            }
            Console.ReadLine();
        }
    }
}
