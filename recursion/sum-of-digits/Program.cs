using System;

namespace sum_of_digits
{
    internal class Program
    {
        public static int SumOfDigits(int num)
        {
            //Base Condition in the end it will return 0 
            if (num == 0)
            {
                return 0;
            }
            //Console.WriteLine(num%10);
            return (num % 10 + SumOfDigits(num / 10));
        }

        public static int ProductOfDigits(int num)
        {
            // Below base condition is wrong because it will return 0 and anything later multplied by zero will be zero
            //if (num == 0)
            //{
            //    return 0;
            //}

            //Base Condition
            //will not return zero, rather simply return 'n' if it is last number which is received in the function input
            if (num%10 == num)
            {
                return num;
            }
            return (num % 10 * ProductOfDigits(num / 10));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumOfDigits(1234));
            Console.WriteLine(ProductOfDigits(1234));
            //if number containing zero is given in imput, product should return zero the 
            Console.WriteLine(ProductOfDigits(12034));
        }
    }
}
