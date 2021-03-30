using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
    
public class Calc
{
    public int x; 

    public void Result(int x)
    {
        this.x = x / 2;
    }

    public void Result(string x)
    {
        Console.WriteLine($"Overload method, x is now text --> {x}");
    }
    
    public static void MultiplyB(out int a, out int b)
    {
        a = 25;
        b = 5;
        a *= a;
        b *= b;
    }
}

