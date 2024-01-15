using System;

class Program
{
    static void Main()
    {
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int target = 6;
        int result = BinarySearch(sortedArray, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}.");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            Console.WriteLine($"Checking element at index {middle}: {array[middle]}");

            // checking if target is present at the middle
            if (array[middle] == target)
            {
                return middle;
            }

            // if target is greater, ignore the left half
            if (array[middle] < target)
            {
                left = middle + 1;
            }
            // if target is smaller, ignore the right half
            else
            {
                right = middle - 1;
            }
        }

        // If we reach here, the element was not present
        return -1;
    }
}
