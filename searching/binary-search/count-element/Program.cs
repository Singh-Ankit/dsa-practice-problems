using System;
using find_first_last_occurrence;
namespace count_element
{
    public class Program
    {
        /*
         * Q. Given a sorted array arr[] and a number x, write a function that counts the occurrences of x in arr[]. Expected time complexity is O(Logn) 
         * 
         *
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 4, 4, 4, 6, 7 };
            int target = 4;
            int firstOccurrence= find_first_last_occurrence.Program.FirstOccurence(arr,target);
            int lastOccurrence= find_first_last_occurrence.Program.LastOccurence(arr,target);

            //using formula (lastOccurrence -  firstOccurrence + 1)
            int count = lastOccurrence - firstOccurrence + 1;
            Console.WriteLine($"count of {target} in arr : {count}");

        }
    }
}
