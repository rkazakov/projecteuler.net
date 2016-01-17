using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        private static int num1;
        private static int num2;
        private static int sum;

        static void Main(string[] args)
        {
            //int limit = 4000000;

            //DoFib(32);

            int one = 1;
            int two = 2;

            int sum = 2;

            while (two < 1000000)
            {
                one = one + two;
                if (one % 2 == 0)
                    sum = sum + one;

                two = one + two;
                if (two % 2 == 0)
                    sum = sum + two;
            }

            /*
            long sum = 0, i0, i1 = 1, i2 = 2;
            do
            {
                sum += i2;
                for (int i = 0; i < 3; i++)
                {
                    i0 = i1;
                    i1 = i2;
                    i2 = i1 + i0;
                }
            } while (i2 < 4000000);
            */

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static void DoFib(int num)
        {
            int temp_value;
            if (num < 2)
            {
                num1 = 1;
                num2 = 2;
            }
            else
            {
                DoFib(num - 1);
                temp_value = num2;
                num2 = num1 + num2;
                num1 = temp_value;
                if (num1 % 2 == 0) sum += num1;
                Console.WriteLine(num1);
            }
        }

        public static int Fibonacci(int a)
        {
            if (a <= 1)
            {
                return 1;
            }
            return Fibonacci(a-1) + Fibonacci(a-2);
        }
    }
}
