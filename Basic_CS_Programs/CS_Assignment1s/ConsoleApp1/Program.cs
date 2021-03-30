using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console App Assignment Part Four - p200
            List<string> pets = new List<string>() { "Dog", "Cat", "Bird" };

            Console.WriteLine("Please pick one: Dog, Cat, Bird");
            string userPick = Console.ReadLine();
            Console.WriteLine();

            for (int a = 0; a < pets.Count; a++)
            {
                if (userPick != pets[a])
                {
                    do
                    {
                        Console.WriteLine("Incorrect entry, please try again.");
                        Console.WriteLine("Please pick one: Dog, Cat, Bird");
                        userPick = Console.ReadLine();
                        Console.WriteLine();
                    }
                    while (userPick != pets[a]);
                }
                int iPet = pets.IndexOf(userPick);
                Console.WriteLine(iPet);
                Console.WriteLine("Good Bye!!");
                break;
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            Console.ReadLine();
            
        }
    }
}
