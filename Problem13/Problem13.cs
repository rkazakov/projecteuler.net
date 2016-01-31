using System;
using System.IO;
using System.Numerics;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            var bi = new BigInteger();

            TextReader sr = new StreamReader("Problem13.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
                bi += BigInteger.Parse(line);

            Console.WriteLine(bi.ToString().Substring(0,10));
            Console.ReadKey();
        }

    }
}
