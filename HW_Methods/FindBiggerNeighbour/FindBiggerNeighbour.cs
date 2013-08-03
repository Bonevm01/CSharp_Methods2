//5.Write a method that checks if the element at given position in given array of integers is bigger than
//  its two neighbors (when such exist).
using System;

public class FindBiggerNeighbour
{
    public static bool IsBiggerNeighbour(int a, int[] array)
    {

        bool isBigger = false;
        if (a == 0)
        {
            if (array[a] > array[a + 1])
            {
                isBigger= true;
            }
        }
        else if (a == array.Length - 1)
        {
            if (array[a] > array[a - 1])
            {
                isBigger= true;
            }
        }

        else
        {
            if (array[a] > array[a - 1] && array[a] > array[a + 1])
            {
                isBigger= true;

            }
          
        }
        return isBigger;

    }
    static void Main()
    {
        int[] myArray = { 1, 4, 3, 7, 15, 12, 8, 3, 0, -5, 12, 14 };
        int input = int.Parse(Console.ReadLine());
        if (input < 0 || input >= myArray.Length)
        {
            Console.WriteLine("Your input was not valid. Next time enter a number bethween 0 and {0}.", myArray.Length - 1);
        }
        else
        {
            Console.WriteLine("The member on possition {0} in your array is bigger than its two neighbours -->{1}.", input, IsBiggerNeighbour(input, myArray));
        }
    }
}
