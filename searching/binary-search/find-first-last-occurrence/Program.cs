using System;

namespace find_first_last_occurrence
{
    /*
     * Q. Given a sorted array with possibly duplicate elements, find indexes of first and last occurrences of an element target in the given array.
     * 
     * Time Complexity : O(log n) 
     * Auxiliary Space : O(1) 
     */

    public class Program
    {
        public static int FirstOccurence(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int first = -1;

            while (start <= end)
            {
                //calculating mid
                int mid = start + (end - start) / 2;

                // if mid is equal target, we update FIRST and move to LEFT HALF to check if any prior occurrence of target is present
                if (target == arr[mid])
                {
                    first = mid;
                    //move to left half
                    end = mid - 1;
                }

                // Normal Binary Search Approach
                else if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return first;
        }

        public static int LastOccurence(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            // this variable stores our result
            int last = -1;

            while (start <= end)
            {
                //calculate mid
                int mid = start + (end - start) / 2;

                // if mid is equal target, we update LAST and move to RIGHT HALF to check if any subsequent occurrence of target is present
                if (target == arr[mid])
                {
                    last = mid;
                    //Move to RIGHT HALF
                    start = mid + 1;
                }

                // Normal Binary Search Approach
                else if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return last;
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 4, 4, 4, 6, 7 };
            int[] arr = { 1, 2, 3, 4, 5, 5 };

            int resultFirstOccurrence = FirstOccurence(arr, 5);
            Console.WriteLine(resultFirstOccurrence);
            int resultLastOccurrence = LastOccurence(arr, 5);
            Console.WriteLine(resultLastOccurrence);
        }
    }
}
