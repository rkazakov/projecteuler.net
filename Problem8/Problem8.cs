using System;
using System.IO;

namespace Problem8
{
    class Program
    {
        static int product = 0;

        static void Main(string[] args)
        {
            TextReader tr = new StreamReader("problem8.txt");
            string d = tr.ReadToEnd();

            for (int i = 0; i < d.Length-4; i++)
            {
                int temp = getProduct(int.Parse(d[i].ToString()), int.Parse(d[i + 1].ToString()), int.Parse(d[i + 2].ToString()),
                        int.Parse(d[i + 3].ToString()), int.Parse(d[i + 4].ToString()));
                if (product < temp)
                {
                    product = temp;
                }
            }

            Console.WriteLine(product);
            Console.ReadKey();
        }

        static int getProduct(int a, int b, int c, int d, int e)
        {
            return a*b*c*d*e;
        }
    }
}
