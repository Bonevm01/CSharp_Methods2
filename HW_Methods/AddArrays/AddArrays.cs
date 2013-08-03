//8.Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//  the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;

class AddArrays
{
    static void AddTwoArrays(int[] a, int[] b)
    {
        int minLength, maxLength;
        int[] minArray;
        int[] maxArray;
        if (a.Length > b.Length)
        {
            maxLength = a.Length;
            minLength = b.Length;
            minArray = (int[])b.Clone();
            maxArray = (int[])a.Clone();

        }
        else
        {
            minLength = a.Length;
            maxLength = b.Length;
            minArray = (int[])a.Clone();
            maxArray = (int[])b.Clone();
        }
        int[] result = new int[maxLength + 1];
        int naUm = 0;
        result[0] = (minArray[0]+maxArray[0])%10;
        for (int i = 1; i < maxLength; i++)
        {
            if (i<=minLength-1)
            {
                result[i] = ((minArray[i] + maxArray[i]) + (minArray[i - 1]+maxArray[i-1]) / 10)%10;
                naUm = ((minArray[i] + maxArray[i]) + (minArray[i - 1] + maxArray[i - 1]) / 10) / 10;
            }
            
            else
            {
                result[i] = (maxArray[i] + naUm)%10;
                naUm = (maxArray[i] + naUm) / 10;
            }
        }
        Console.Write(new string(' ', result.Length-a.Length));
        for (int i = a.Length-1; i >= 0; i--)
        {
            Console.Write(a[i]);
        }
        Console.WriteLine();
        Console.WriteLine("+");
        Console.Write(new string(' ', result.Length - b.Length));
        for (int i = b.Length - 1; i >= 0; i--)
        {
            Console.Write(b[i]);
        }
        Console.WriteLine();
        Console.WriteLine(new string('_', result.Length));


        if (result[result.Length-1]!=0)
        {
            Console.Write(result[result.Length-1]);
        }
        else
        {
            Console.Write(" ");
        }

        for (int i = result.Length - 2; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();

    }

    static void Main()
    {
        int[] firstInt = { 1, 5, 6, 9, 7, 1, 3, 0, 5, 8, 7, 6, 8, 4, 1, 5, 2, 9, 9, 9, 3, 4, 7, 2, 5, 8, 9, 6, 5 };
        int[] secondInt = { 2, 5, 6, 9, 7, 4, 5, 7, 2, 5, 8, 2, 5, 6, 7, 6, 8 };
        AddTwoArrays(secondInt, firstInt);
    }
}