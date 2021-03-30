using System;


namespace CS_Assignment5_pg152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hrsRate1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hrsWorked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hrsRate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hrsWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1: ");
            int yearlySalary1 = (hrsWorked1 * hrsRate1) * 52;
            Console.WriteLine(yearlySalary1);

            Console.WriteLine("Annual salary of Person 2: ");
            int yearlySalary2 = (hrsWorked2 * hrsRate2) * 52;
            Console.WriteLine(yearlySalary2);

            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool compareWages = yearlySalary1 > yearlySalary2;
            Console.WriteLine(compareWages);

            Console.ReadLine();
        }
    }
}
