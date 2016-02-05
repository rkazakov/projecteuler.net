using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;

            string str1 = Power(2, 1000).ToString();
            for (int i = 0; i < str1.Length; i++)
                sum1 += Int32.Parse(str1[i].ToString());

            Console.WriteLine(sum1);

            int sum2 = 0;

            string str2 = PowerRec(2, 1000).ToString();
            for (int i = 0; i < str2.Length; i++)
                sum2 += Int32.Parse(str2[i].ToString());

            Console.WriteLine(sum2);

            Console.ReadKey();
        }

        private static BigInteger PowerRec(BigInteger x, short power)
        {
            if (power <= 1) return x;
            else return x * PowerRec(x, --power);
        }

        private static BigInteger Power(BigInteger x, int power)
        {
            BigInteger t = x;
            for (int i = 1; i < power; i++)
                x = t * x;
            return x;
        }

    }
}
