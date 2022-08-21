using System;

namespace defanged_ip_address
{
    public class Program
    {
        public static string DefangedIP(string input) 
        {
            string result = "";
            
            for(int i = 0; i < input.Length; i++)
            {
                //Console.WriteLine(input[i].GetType());
                if (input[i] == '.')
                {
                    //result is of type string, anything can be added to string. It can be char or string itself
                    result += "[.]";
                }else
                {
                    result += input[i]+""; //or result += string(input[i])
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string str = "255.100.50.0";
            Console.WriteLine(DefangedIP(str));
        }
    }
}
