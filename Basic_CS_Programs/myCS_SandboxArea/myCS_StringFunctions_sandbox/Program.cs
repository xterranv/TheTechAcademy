using System;
using System.Text;

namespace myCS_StringFunctions_sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string name2 = "CAROLINE";
            //escape sequence examples \n new line, \t tab, \"text\" - prints text in quotes "text"
            string quote = "The dog said, \"hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab";
            string filename = "c:\\user\\jesse";
            //the @ tells it that everything after the @ sign is part of the string
            string filename2 = @"c:\user\jesse";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");

            int length = name.Length;

            name = name.ToUpper();
            name2 = name2.ToLower();

            //immutable - once created you can't change them
            StringBuilder sb = new StringBuilder();
            sb.Append("my name is Bridget");
            Console.WriteLine(sb);

            Console.WriteLine(quote);
            Console.WriteLine(filename);
            Console.WriteLine(filename2);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.ReadLine();
        }
    }
}
