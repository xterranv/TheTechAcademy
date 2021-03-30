using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nbrList = new List<int>() { 1, 3, 5, 555, 342, 23 };
            List<int> newList = new List<int>();

            int sum = nbrList.Sum();
            int max = nbrList.Max();
            int min = nbrList.Min();
            
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);            

            int sum2 = sum -= max;

            Console.WriteLine(sum2);
            Console.WriteLine();

            foreach (int nbr in nbrList)
            {
                if (nbr > 20)
                {
                    newList.Add(nbr);
                }
            }

            foreach (int num in newList)
            {
                Console.WriteLine(num);
            }            

            Console.ReadLine();
        }        
    }
}
