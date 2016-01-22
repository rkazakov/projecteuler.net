using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 1;

            for (long h = 1; h <= 3000000000; h++)
            {
                if (h % 100000 == 0)
                    Console.WriteLine("Trying: " + h);

                if (isDevided(h))
                {
                    x = h; break;
                }
            }

            Console.WriteLine("Result: " + x);
            Console.ReadKey();
        }

        static bool isDevided(long x)
        {
            for (long i = 1; i <= 20; i++)
                if (x % i != 0)
                    return false;
            return true;
        }
    }
}
