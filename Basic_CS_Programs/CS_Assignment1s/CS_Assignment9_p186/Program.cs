using System;
using System.Text;

namespace CS_Assignment9_p186
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name?");
            string fname = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your favorite day?");
            string day = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello " + fname + ", It's a wonderful " + day + " to have " + food.ToUpper() + "!!");
            Console.WriteLine();

            Console.WriteLine("This is an example of a StringBuilder built paragraph:");
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, my name is Bridget and ");
            sb.Append("I live in NH.\nAnd I'm Learning A LOT ");
            sb.Append("in the Online C# course ");
            sb.Append("that I'm taking at The Tech Academy!!");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
