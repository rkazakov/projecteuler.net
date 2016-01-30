using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;

            for (long i = 1; i <= 2000000; i++)
                if (isPrime(i))
                    sum += i;

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        private static bool isPrime(long x)
        {
            if (x == 2)
                return true;

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
