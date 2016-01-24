using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;
            int sum1 = 0;
            int sum2 = 0;

            for (int i=1; i<=limit; i++)
                sum1 += i*i;

            for (int i = 1; i <= limit; i++)
                sum2 += i;

            Console.WriteLine(sum2 * sum2 - sum1);
            Console.ReadKey();
        }
    }
}
