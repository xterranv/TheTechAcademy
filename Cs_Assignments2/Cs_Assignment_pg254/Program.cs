using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg254
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current Day");
                string inputDay = Console.ReadLine().ToLower();
                Console.WriteLine();

                WeekDays enumDay = (WeekDays)Enum.Parse(typeof(WeekDays), inputDay);

                Console.WriteLine($"You entered {inputDay} which correspondes to the");
                Console.WriteLine($"Enum value {enumDay} and Enum integer value of {(int)enumDay}");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day");
            }                                    

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }        
    }
}
