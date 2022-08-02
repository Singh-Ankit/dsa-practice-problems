using System;

namespace peak_bitonic_array
{
    /*
     * Q. Peak Index in a Mountain Array
     * 
     * Bitonic array is a whose values at indexes increases in one half and decreases in second half. It's shape is similar to a mountain
     * ex: 1,2,3,4,3,2,1
     * ex: 1,2,15,26,25,12,10
     * 
     * LINK: https://leetcode.com/problems/peak-index-in-a-mountain-array/
     * Conplexity is o(logn)
     */
    public class Program
    {
        //this function returns the index of the peak element
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                //calculating mid
                int mid = start + (end - start) / 2;
                int next = mid + 1;
                int prev = mid - 1;

                if (arr[mid] >= arr[next] && arr[mid] >= arr[prev])
                {
                    return mid;
                }
                else if (arr[next] >= arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 10, 5, 2 };
            Console.WriteLine(PeakIndexInMountainArray(arr));
        }
    }
}
