using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(BinarySearch(nums, 2));
    }

    public static int BinarySearch(int[] arr, int key)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == key)
            {
                return mid;
            }
            else if (arr[mid] < key)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }


}