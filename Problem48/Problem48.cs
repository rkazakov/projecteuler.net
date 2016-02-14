using System;
using System.Numerics;

namespace Problem48
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = 1000;
            var bi = new BigInteger();

            for (short i = 1; i <= n; i++)
                bi += Pow(i, i);

            Console.WriteLine(bi.ToString().Substring(bi.ToString().Length-10, 10));
            Console.ReadKey();
        }

        private static BigInteger Pow(BigInteger x, int p)
        {
            if (p < 0) return 1/Pow(x, -p);
            else if (p == 1) return x;
            else return x*Pow(x, --p);
        }

    }
}
