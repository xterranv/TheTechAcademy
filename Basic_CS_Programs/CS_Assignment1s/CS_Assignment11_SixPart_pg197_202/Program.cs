using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Assignment Part One - p197
            string[] colors = { "RED", "BLUE", "GREEN", "YELLOW" };

            Console.WriteLine("Please enter a bird species:");
            string bird = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < colors.Length; i++)
            {
                {
                    Console.WriteLine(colors[i] + " " + bird);
                }
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            //Console App Assignment Part Two - p198
            Console.WriteLine("Please enter a number from 0 - 5: ");
            int nbr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int x = nbr; x < 11; x++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            //Console App Assignment Part three - p199
            Console.WriteLine("Please enter another number from 5 - 10: ");
            int nbr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int x = nbr2; x > 0; x--)
            {
                Console.WriteLine(x);
            }

            //Part three - p199
            Console.WriteLine("Please enter a number from 50 - 55: ");
            int nbr3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int x = nbr3; x <= 60; x++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            //Console App Assignment Part Four - p200
            List<string> pets = new List<string>() { "Dog", "Cat", "Bird" };

            Console.WriteLine("Please pick one: Dog, Cat, Bird");
            string usrPick = Console.ReadLine();
            Console.WriteLine("You entered " + usrPick);
            Console.WriteLine("");

            if (!pets.Contains(usrPick))
            {
                do
                {
                    Console.WriteLine("That's an Incorrect Entry");
                    Console.WriteLine("Please pick one: Dog, Cat, Bird");
                    usrPick = Console.ReadLine();
                    Console.WriteLine("You entered " + usrPick);
                    Console.WriteLine("");
                }
                while (!pets.Contains(usrPick));
            }

            //Loop
            for (int p = 0; p < pets.Count; p++)
            {
                //get index
                string uMsg = pets[p];

                if (usrPick == uMsg)
                {
                    Console.WriteLine($"Index {p} is {uMsg}");
                }


            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            //Console App Assignment Part Five - p201
            List<string> names = new List<string>() { "Peter", "John", "Bobby", "John" };

            Console.WriteLine("Please pick a name: Peter, John, Bobby");
            string nameInput = Console.ReadLine();
            Console.WriteLine("You Entered: " + nameInput);
            Console.WriteLine();

            if (!names.Contains(nameInput))
            {
                do
                {
                    Console.WriteLine("Incorrect entry, please select a name from the list");
                    nameInput = Console.ReadLine();
                    Console.WriteLine("You Entered: " + nameInput);
                    Console.WriteLine();
                }
                while (!names.Contains(nameInput));
            }

            //Loop
            for (int v = 0; v < names.Count; v++)
            {

                if (nameInput == names[v])
                {
                    Console.WriteLine($"Index {v} contains the name you entered: {nameInput}");
                }
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            //Console App Assignment Part Six - p202
            List<string> texts = new List<string>() { "Blue", "Moose", "Bear", "Red", "Moose", "Bear" };
            Console.WriteLine("Click ENTER to see what the Elements in the list are:");
            Console.ReadLine();
            texts.ForEach(Console.WriteLine);
            Console.WriteLine(" ");

            var t = texts.GroupBy(s => s);

            foreach (var dupe in t)
            {
                Console.WriteLine("{0} shows up {1} times", dupe.Key, dupe.Count());
            }

            Console.ReadLine();
            
        }
    }
}