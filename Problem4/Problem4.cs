using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 0;

            for (int i = 100; i <= 999; i++)
                for (int j = 100; j <= 999; j++)
                    if (isPal(i * j) && i * j > product)
                        product = i * j;

             Console.WriteLine(product);
             Console.ReadKey();
        }

        private static bool isPal(int x)
        {
            string str = x.ToString();
            int strLen = str.Length;
            for (int i = 0; i < strLen / 2; i++)
                if (str[i] != str[strLen - i - 1])
                    return false;
            return true;
        }
    }
}
