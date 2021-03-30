using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] petArray = { "Cat", "Dog", "Bird", "Fish", "Horse" };
        int[] nbrArray = { 15, 25, 35, 45, 55, 65, 75, 85 };
        
        List<string> strList = new List<string>();
        strList.Add("A smile dispels many worries.");
        strList.Add("Keep the general goal in sight while tackling daily tasks.");
        strList.Add("Every step makes a footprint.");
        strList.Add("Failure is the mother of success.");
        strList.Add("Fate brings people together from far apart");
        

        Console.WriteLine("Welcome. What's your lucky Pet and Number.... Answer the questions below to find out.");
        Console.WriteLine("Pick a number from 0 - 7");
        int luckyNbr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();      

        if (luckyNbr > 7 || luckyNbr < 0)
        {
            do
            {
                Console.WriteLine("That's an incorrect selection");
                Console.WriteLine("Please enter a number between 0 - 7");
                luckyNbr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            while (luckyNbr > 7 || luckyNbr < 0);
        }

        Console.WriteLine("Pick a number between 0 - 4");
        int luckyPet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (luckyPet > 4 || luckyPet < 0)
        {
            do
            {
                Console.WriteLine("That's an incorrect selection");
                Console.WriteLine("Please select a number between 0 - 4");
                luckyPet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            while (luckyPet > 4 || luckyPet < 0);
        }           
        Console.WriteLine("Your lucky number is " + nbrArray[luckyNbr] + " and you're lucky pet is " + petArray[luckyPet]);
        Console.WriteLine();

        Console.WriteLine("Please select a number between 0 - 4");        
        int fortune = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (fortune > 4 || fortune < 0)
        {
            do
            {
                Console.WriteLine("That's an incorrect selection");
                Console.WriteLine("Please select a number between 0 - 4");
                fortune = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            while (fortune > 4 || fortune < 0);
        }
        Console.WriteLine("You lucky chinese proverb is:\n" + strList[fortune]);


        Console.ReadLine();
    }
}
