using System;

class Program
{
    static void Main()
    {
        // Clear the console screen!
        Console.Clear();

        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Sorted Array Contents: ");
        foreach (var element in sortedArray)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine(); // add a newline for better formatting

        Console.Write("Enter the target element: ");
        if (int.TryParse(Console.ReadLine(), out int target))
        {
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
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
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

        // if we reach here, the element was not present!
        return -1;

        // Will add output to file
    }
}

//Binary search is a search algorithm used to find the position of a target value within a sorted array or list. It works by repeatedly dividing the search interval in half, reducing the portion of the data being searched, until the target value is found or the search interval is empty.
