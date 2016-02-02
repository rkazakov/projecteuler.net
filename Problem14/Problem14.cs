using System;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            long limit = 1000000;
            long biggest = 0;
            long counter = 0;

            for (long i=2; i<=limit; i++)
            {
                long c = GenSeq(i, 1);
                if (counter < c)
                {
                    counter = c;
                    biggest = i;
                }

                if (i % 10000 == 0) Console.WriteLine(i);
            }

            Console.WriteLine(String.Format("Number {0} has {1} terms.", biggest, counter));
            Console.ReadKey();
        }

        static long GenSeq(long n, long c)
        {
            if (n == 1) return c;
            c++;
            if (n % 2 == 0) return GenSeq(n / 2, c);
            return GenSeq(3*n + 1, c);
        }


    }
}
