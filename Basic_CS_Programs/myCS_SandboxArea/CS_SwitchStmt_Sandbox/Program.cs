using System;
using System.Collections.Generic;

namespace mySwitchStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test = new List<string> { "Dog", "Cat", "Bird" };

            Console.WriteLine("Enter: Dog, Cat, or Bird");
            string userPick = Console.ReadLine();
            Console.WriteLine();

            string pet = userPick;
            switch (pet)
            {
                case "Dog":
                    Console.WriteLine(test);
                    break;
                case "Cat":
                    Console.WriteLine(test);
                    break;
                case "Bird":
                    Console.WriteLine(test);
                    break;
            }



            //int day = 5;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}
            //Console.ReadLine();
        }
    }
}
