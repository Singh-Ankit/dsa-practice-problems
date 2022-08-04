using System;

namespace fibonacci_series
{
    /*
     * This is not an optimised solution
     *  TODO:: optimisation
     */
    internal class Program
    {
        public static int Fibo(int n)
        {
            //Base condition
            if (n < 2)
            {
                return n;
            }

            return Fibo(n - 1)+Fibo(n-2);
        }
        static void Main(string[] args)
        {
            int result = Fibo(50);
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
