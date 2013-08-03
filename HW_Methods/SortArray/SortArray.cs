//9.Write a method that return the maximal element in a portion of array of integers starting at given index.
//  Using it write another method that sorts an array in ascending / descending order.

using System;

class SortArray
{
    static int FindMaxInArray(int start, int[] array)
    {
        int maxValue = int.MinValue;
        for (int i = start; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        return maxValue;
    }
    static int FindIndexMaxValInArray(int start, int[] array)
    {
        int maxValue = int.MinValue;
        int index = 0;
        for (int i = start; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                index = i;
            }
        }
        return index;
    }

    private static void DescSortArray(int[] workingArray) //Selection sort
    {
        for (int i = 0; i < workingArray.Length; i++)
        {
            int maxVal = FindMaxInArray(i, workingArray);
            int index = FindIndexMaxValInArray(i, workingArray);
            if (index != i)
            {
                int tempor = workingArray[i];
                workingArray[i] = maxVal;
                workingArray[index] = tempor;
            }

        }
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Please choose how to sort your array: a-ascending; d-descending: ");
        string input = Console.ReadLine();
        int[] workingArray = { 1, 3, 5, 7, -2, -7, 12, 8, -14, 26, 25, 2, 6 };
        int[] ascSortedArray = new int[workingArray.Length];//To save ascending array if such have been choosen
        DescSortArray(workingArray);
        if (input == "d")
        {
            PrintArray(workingArray);
        }
        if (input == "a")
        {
            for (int i = 0; i < workingArray.Length; i++)
            {
                ascSortedArray[workingArray.Length - 1 - i] = workingArray[i]; //Reverse working array
            }
            PrintArray(ascSortedArray);
        }
    }


}
