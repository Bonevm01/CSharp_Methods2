//6.Write a method that returns the index of the first element in array that is bigger than its neighbors,
//  or -1, if there’s no such element. Use the method from the previous exercise.

using System;

class FirstBigger
{
    
    static int FirstBiggerMember(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (FindBiggerNeighbour.IsBiggerNeighbour(i, array))
            {
                index = i;
                break;
            }
                               
        }
        return index;

    }
    static void Main()
    {
        int[] myArray = { 2, 2, 6, 7, 15, 14, 8, 3 };

        if (FirstBiggerMember(myArray) >= 0) Console.WriteLine("The first member bigger than its neighbours is on possition {0}.",FirstBiggerMember(myArray));
        else Console.WriteLine("There is no elemet in your array bigger than its neighbours.");
    }
}
