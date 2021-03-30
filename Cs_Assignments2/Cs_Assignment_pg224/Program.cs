using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        Calc result = new Calc();

        Console.WriteLine("Enter a number");
        int value = Convert.ToInt32(Console.ReadLine());

        result.Result(value);

        Console.WriteLine($"{value} divided by 2 is {result.x}");
        Console.WriteLine();

        string s = "X is now Text";
        result.Result(s);
        Console.WriteLine();

        int m, n;
        Calc.MultiplyB(out m, out n);
        Console.WriteLine("25 times 25 is: {0}", m);
        Console.WriteLine("5 times 5 is: {0}", n);
        Console.WriteLine();

        Books.Details();
        Console.WriteLine("Book Title: {0} ", Books.title);

        Console.ReadLine();
    }
}
