using System;

namespace find_floor_ceil_sorted_array
{
    public class Program
    {
        public static int FindFloorInSortedArray(int[] arr,int length, int target)
        {
            int start = 0;
            int end = length - 1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                
                if(target == arr[mid])
                {
                    return mid;
                }
                else if (target >= arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return end;
        }

        public static int FindCeilInSortedArray(int[] arr, int length, int target)
        {
            int start = 0;
            int end = length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == arr[mid])
                {
                    return mid;
                }
                else if (target >= arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return start;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,8,10,10,12,14 };
            Console.WriteLine("Hello World!");
            Console.WriteLine(FindFloorInSortedArray(arr,9,19));
            Console.WriteLine(FindCeilInSortedArray(arr, 9, 19));
        }
    }
}
