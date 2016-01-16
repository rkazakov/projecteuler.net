using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 1000;
            int sum = 0;
            for (int n = 1; n < limit; n++)
                if (n % 3 == 0 || n % 5 == 0)
                    sum += n;

            Console.WriteLine(sum);
        }
    }
}
