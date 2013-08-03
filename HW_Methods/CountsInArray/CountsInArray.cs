//4. Write a method that counts how many times given number appears in given array.
//  Write a test program to check if the method is working correctly.

using System;

namespace Counts
{

    public class CountsInArray
    {
        public static int Count(int a, int[] array)
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    index++;
                }
            }
            return index;
        }
        static void Main()
        {
            int[] myArray = { 1, 18, 5, 4, 7, 13, 2, 1, 9, 4, 7, 13, 2, 4, 17, 21, 19, 15, 13, 2, 8, 7, 6, 4, 12 };
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} appears {1} times in your array.", input, Count(input, myArray));
        }
    }
}
