using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg310
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string locationName = "Destination Adventures";

            var cityName = new Dictionary<string, string>() {
                {"UK-ENG", "London, England" },
                {"IRL", "Dublin, Ireland" },
                {"AUS", "Melbourne, Australia" },
                {"LA-USA", "Los Angeles, USA" }
            };            
            
            Console.WriteLine("Welcome to the {0}", locationName);
            Console.WriteLine($"You purchased our {cityName["AUS"]} Destination Adventure package.\n Enjoy your trip!!\n");

            Sale sale = new Sale("Sean Flynn");            

            Console.ReadLine();
        }
    }
}
