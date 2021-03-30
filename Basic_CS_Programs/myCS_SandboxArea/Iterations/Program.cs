using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array iteration with a FOR Loop
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] >= 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //String array interation with a FOR Loop
            //string[] names = { "Jesse", "Erik", "Dan", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }

            //}


            //iteration for a list with a FOREACH Loop
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score> 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}


            //iteration for a list (string) with a FOREACH Loop
            //List<string> names = new List<string>() {"Jesse", "Erik", "Adam", "Dan"};

            //foreach (string name in names)
            //{
            //    //if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}


            //Iterate a list and if it meets the specific criteria then add it to another list (COUNT)
            List<int> testScores = new List<int>() { 98, 99, 30, 74, 25, 99 };
            List<int> passScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passScores.Add(score);
                }
            }
            Console.WriteLine(passScores.Count);

            Console.ReadLine();

        }
    }
}
