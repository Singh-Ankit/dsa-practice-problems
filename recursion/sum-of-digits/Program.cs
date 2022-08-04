using System;

namespace sum_of_digits
{
    internal class Program
    {
        public static int SumOfDigits(int num)
        {
            //Base Condition
            if(num % 10 == num)
            {
                return num;
            }
            return (num % 10 + SumOfDigits(num / 10));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumOfDigits(1234));
        }
    }
}
