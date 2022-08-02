using System;

namespace count_array_rotation
{
    public class Program
    {
        public static int NumberOfTimesSortedArrayIsRotated(int[] arr, int length)
        {
            int start = 0;
            int end = length-1;

            while(start <= end)
            {
                Console.WriteLine($"start is {arr[start]} and end is {arr[end]}");
                //calculate mid
                int mid = start + (end - start)/2;
                Console.WriteLine($"mid is {arr[mid]}");
                int next = (mid + 1) % length; //instead of writing (mid + 1)
                Console.WriteLine($"next is {arr[next]}");
                int prev = (mid - 1 + length) % length;
                //int prev = (mid + length - 1) % length; //instead of writing (mid - 1)
                Console.WriteLine($"prev is {arr[prev]}");

                // return mid if our mid is itself the smallest | i.e, mid must be smaller then prev and next
                if (arr[mid] <= arr[next] && arr[mid] <= arr[prev])
                {
                    Console.WriteLine($"samller is : {mid}");
                    return mid;
                }
                // partition the array into sorted and unsorted part
                // what is called sorted, a part where either mid is smaller than end or mid is greater than start
                else if (arr[mid] <= arr[end])
                {
                    Console.WriteLine($"----- setting start as {mid + 1}");
                    // first half is already sorted. So, update start to secon half i.e start = mid + 1
                    end = mid - 1;
                }
                else
                {
                    Console.WriteLine($"----- setting end as {mid - 1}");
                    start = mid + 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 11, 12, 15, 18, 2, 5, 6, 8 };
            //int[] arr = { 15, 18, 2, 3, 6, 12 };
            int length = arr.Length;
            Console.WriteLine("No. Of time array is rotated is : "+ NumberOfTimesSortedArrayIsRotated(arr, length));
        }
    }
}
