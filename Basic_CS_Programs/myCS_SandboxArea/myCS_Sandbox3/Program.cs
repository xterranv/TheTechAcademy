using System;

namespace myCS_Sandbox3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 37;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 55:
                        Console.WriteLine("You guess 55. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 37:
                        Console.WriteLine("You guessed number 37. That's correct!!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You guessed wrong.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            //adding the ! before the variable name is the same as saying isGuessed == false
            while (!isGuessed);
                       
            Console.ReadLine();

        }
    }
}
