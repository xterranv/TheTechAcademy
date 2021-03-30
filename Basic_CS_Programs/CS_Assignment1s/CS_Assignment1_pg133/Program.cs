using System;

namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What Page are you on?");
            string pageOn = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Do you need help with anything? Please answer True or False");
            //string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics?");
            string anyPositives = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string anyFeedback = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("How many hours did you study today?");
            string studied = Console.ReadLine();
            int studyHours = Convert.ToInt32(studied);
            Console.WriteLine("");

            Console.WriteLine("Thank you for submitting your report " + studentName);
            Console.WriteLine("Here's a sumamry of your responses:");
            Console.WriteLine("");

            Console.WriteLine("You are on course: " + courseName + " on page " + pageOn + ",");
            Console.WriteLine("Assistance needed?: " + needHelp + ",");
            Console.WriteLine("Positives so far are: " + anyPositives + ",");
            Console.WriteLine("Your feedback: " + anyFeedback + ",");
            Console.WriteLine("Hours studied today: " + studyHours);
            Console.WriteLine("");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("This is the end of the program");

            Console.ReadLine();
        }
    }
}
