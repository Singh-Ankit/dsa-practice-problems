using System;

namespace recursion
{
    internal class Program
    {
        public static int PrintNumberWithReturnType(int n)
        {
            //Base condition
            if (n == 0)
            {
                return n;
            }
           // Console.WriteLine(n);
            return PrintNumberWithReturnType(n - 1);
        }
        public static void PrintNumber(int n)
        {
            //Base condition
            if(n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintNumber(n - 1);
        }

        public static void PrintNumberReverseOrder(int n)
        {
            //Base condition
            if (n == 0)
            {
                return;
            }
            //Don't print here let all recursive function in the tree to execute first
            // Console.WriteLine("-->"+n);
            PrintNumberReverseOrder(n - 1);

            //Once all recursive functions have already executed,now print
            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("PrintNumber");
            PrintNumber(3);
            Console.WriteLine("PrintNumberWithReturnType");
            int result = PrintNumberWithReturnType(3);
            Console.WriteLine(result);
            Console.WriteLine("-----");
            PrintNumberReverseOrder(3);
        }
    }
}
