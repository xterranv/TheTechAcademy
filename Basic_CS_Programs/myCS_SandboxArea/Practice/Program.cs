using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    do
                    {
                        Console.WriteLine("Please enter whole positive numbers only.");
                        Console.WriteLine();
                        Console.WriteLine("What is your age");
                        age = int.Parse(Console.ReadLine());
                        
                    } while (age <= 0);
                }                    

                int year = DateTime.Now.Year;
                int dobYear = year - age;
                Console.WriteLine($"Your year of birth is {dobYear}");
                Console.WriteLine();

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid response");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An Error Occurred, please contact your System Admin");
                Console.ReadLine();
                return;
            }
            
        }

    }
}
