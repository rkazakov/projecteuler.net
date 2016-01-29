using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;

            for (int a=1; a<=x; a++)
                for (int b=1; b<=x; b++)
                    for (int c=1; c<=x; c++)
                        if ((a+b+c == x) && (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)) && (a < b) && (b < c) && (a < c))
                        {
                            int pr = a * b * c;
                            Console.WriteLine(String.Format("a: {0}, b: {1}, c:{2}, product:{3}", a, b, c, pr));
                            break;
                        }

            Console.ReadKey();
        }

    }
}
