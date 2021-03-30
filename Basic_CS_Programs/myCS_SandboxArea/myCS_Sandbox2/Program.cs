using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCS_Sandbox2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite number?");
            int favNbr = Convert.ToInt32(Console.ReadLine());

            string results = favNbr == 37 ? "you have an great fav number" : "You don't have a great fav number";
            Console.WriteLine(results);
            Console.ReadLine();

            //int roomTemp = 70;
            //Console.WriteLine("Hello, what's your name?");
            //string name = Console.ReadLine();

            //Console.Write("Hi " + ", What's the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It's exactly room temp");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It's warmer than room temp");
            //}
            //else if (roomTemp> currentTemp)
            //{
            //    Console.WriteLine("It's colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("ummmmm... something went wrong");
            //}


            //int currentTemp = 80;
            //int roomTemp = 70;

            //Ternary statements using INT 
            //string compareResults = currentTemp == roomTemp ? "It's room temp" : "It's not room temp";
            //Console.WriteLine(compareResults);

            //if else statements using above Int
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It's exactly room temperature");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It's warmer than room temperature");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room Temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It's not exactly room temperture");
            //}
            
        }
    }
}
