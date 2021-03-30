using System;

namespace Cs_Assignment_pg314
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please enter your age.");
                Console.ForegroundColor = ConsoleColor.White;
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter whole positive numbers only.\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Please enter your age.");
                        Console.ForegroundColor = ConsoleColor.White;
                        age = int.Parse(Console.ReadLine());

                    } while (age <= 0);
                }

                int year = DateTime.Now.Year;
                int dobYear = year - age;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your year of birth is {dobYear}");
                Console.WriteLine();
                Console.WriteLine("Have a great day.\nPress any key to exit....");
                Console.ReadLine();

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid response");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An Error Occurred, please contact your System Admin");
                Console.ReadLine();
                return;
            }
        }
    }
}
