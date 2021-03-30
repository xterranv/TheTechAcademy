using System;
using System.Security.Cryptography.X509Certificates;

class program
{   
    public static void Main()
    {
        Console.WriteLine("Enter a number");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Optional: Enter another number (you may leave this blank)");
        var y = Console.ReadLine();
        Console.WriteLine();

        int value;
        bool parseSuccess = int.TryParse(y, out value);

        //Console.WriteLine($"value = {value}");
        //Console.WriteLine($"y = {y}");
        //Console.WriteLine($"x = {x}");
        //Console.WriteLine();

        OptOut.MyMath(x, value);
        Console.WriteLine($"The total of {x} + {y} = {OptOut.MyMath(x, value)}");

        Console.ReadLine(); 
    }
}




