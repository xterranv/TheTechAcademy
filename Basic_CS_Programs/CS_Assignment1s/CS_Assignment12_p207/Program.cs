using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CS_Assignment12_p207
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 25, 137, 157, 71 };
                Console.WriteLine("List numbers are:\n");
                numbers.ForEach(Console.WriteLine);
                Console.WriteLine(" ");

                Console.WriteLine("Please enter a number;");
                int iEntry = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine($"Dividing each number in the list by : {iEntry}");

                foreach (var value in numbers)
                {
                    var result = value / iEntry;
                    Console.WriteLine($"{value} divide {iEntry} equals {result}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please don't use 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Click Enter to continue");
                Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Good Bye");
            Console.ReadLine();
        }
        
    }
}
