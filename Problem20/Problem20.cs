using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            BigInteger result = Fac(100);
            string str = result.ToString();

            for (int i = 0; i < str.Length; i++)
                sum += Int32.Parse(str[i].ToString());

            Console.WriteLine(sum);
            Console.ReadKey();
        }


        private static BigInteger Fac(BigInteger x)
        {
            if (x < 0) return Fac(-x);
            else if (x <= 1) return x;
            else return x * Fac(--x);
        }


    }
}
