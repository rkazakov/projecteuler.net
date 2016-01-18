using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 600851475143;
            long xs = (long)Math.Round(Math.Sqrt(x));

            long prime = 0;

            for (long i = xs; i >= 3; i--)
                if (x % i == 0 && isPrime(i))
                {
                    prime = i;
                    break;
                }

            Console.WriteLine(prime);
            Console.ReadKey();
        }

        static bool isPrime(long x)
        {
            if (x <= 1 || x % 2 == 0)
                return false;

            long x_max = (long) Math.Round(Math.Sqrt(x));
            for (long i = 2; i <= x_max; i++)
                if (x % i == 0)
                    return false;
                return true;
        }
    }
}
