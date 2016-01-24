using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            long counter = 0;
            long x = 2;

            while (counter <= 10000)
            {
                if (isPrime(x))
                    counter++;
                x++;
            }

            Console.WriteLine(x);
            Console.ReadKey();
        }

        static bool isPrime(long x)
        {
            if (x == 2)
                return true;

            if (x <= 1 || x % 2 == 0)
                return false;

            long x_max = (long)Math.Round(Math.Sqrt(x));
            for (long i = 2; i <= x_max; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
