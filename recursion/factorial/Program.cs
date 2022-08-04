using System;

namespace factorial
{
    public class Program
    {
        public static int fact(int n)
        {
            //Base condition: no negative numbers or zeros
            if(n <= 1)
            {
                return 1;
            }

            //int result = n * fact(n - 1);
            //return result;
            //OR
            return (n * fact(n - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(fact(4));
        }
    }
}
