using System;


namespace myCS_SandboxArea
{
    class Program
    {
        static void Main()
        {
            int num1 = 7;
            int num2 = 12;
            int num3 = 2;
            int num4 = 8;

            if (num1 <= num2 && num4 >= num3)
            {
                Console.WriteLine("The IF statement ran.");
            }
            else
            {
                Console.WriteLine("The ELSE statement ran.");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            Console.WriteLine("Hello. Do you have a Cat or a Dog?");
            string pet = Console.ReadLine();
            if (pet == "Dog" || pet == "dog")
            {
                Console.WriteLine("You own a Dog!");
            }
            else if (pet == "Cat" || pet == "cat")
            {
                Console.WriteLine("You own a Cat!");
            }
            else
            {
                Console.WriteLine("You don't own a Cat or Dog");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            Console.WriteLine("Does a bear \"do his business\" in the city? (Yes or No)");
            string bear = Console.ReadLine();
            if (bear != "Yes" && bear != "yes")
            {
                Console.WriteLine("Correct... a bear does business in the woods!!");
            }
            else
            {
                Console.WriteLine("You have a problem then... better call the Fish and Game :)");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            int age = 17;
            if (age > 21)
            {
                Console.WriteLine("That will be 25.95 please");
            }
            else
            {
                Console.WriteLine("No you can't purchase that bottle of wine");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            int numx = 7;
            if (numx < 18 &&((numx == 7) ||numx == 2) && ((numx == 8 && numx > 20) || (numx < 20 && numx > 2)))
            {
                Console.WriteLine("Wow, that was confusing");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            int nbr1 = 7;
            int nbr2 = 12;
            string result = nbr1 > nbr2 ? "7 is greater than 12" : "7 is Not greater than 12";
            Console.Write(result);

            Console.ReadLine();
        }
    }
}
