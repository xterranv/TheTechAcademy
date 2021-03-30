using System;

namespace Cs_Assignment_pg219
{
    public class MathClass
    {
        public static int MathAdd(int x)
        {
            return 50 + x;
        }

        public static double MathAdd(double x)
        {
            return 175 + x;
        }

        public static string MathAdd(string x)
        {
            Convert.ToInt32(x);
            return x;
        }

    }
}
