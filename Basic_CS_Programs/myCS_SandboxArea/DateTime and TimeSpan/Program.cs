using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_and_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATETIME EXAMPLE
            DateTime dt = new DateTime(1995, 5, 23, 8, 32, 45);
            Console.WriteLine(dt);
            Console.WriteLine();

            //TIMESPAN EXAMPLE
            DateTime YrOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime YrOfGrad = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGrad = YrOfGrad - YrOfBirth;            
            Console.WriteLine(ageAtGrad);
            Console.WriteLine();

            //Current DateTime
            DateTime currentDt = DateTime.Now;
            Console.WriteLine(currentDt);


            Console.ReadLine();
        }
    }
}
