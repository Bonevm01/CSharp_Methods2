//14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//    Use variable number of arguments.

using System;

class VarArguments
{
    static void Main()
    {
        Console.WriteLine(Minimum(1, 5, -4, 7, 3, 0, 9));
        Console.WriteLine(Maximun(6, 1, -4, 7, 2));
        Console.WriteLine(Average(1, 5, 8, 7));
        Console.WriteLine(Sum(6, 1, 7));
        Console.WriteLine(Product(2, 6, 4, 1));
    }
    static int Minimum(params int[] elements)
    {
        int min = int.MaxValue;
        foreach (var number in elements)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    static int Maximun(params int[] elements)
    {
        int max = int.MinValue;
        foreach (var number in elements)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static double Average(params int[] elements)
    {
        double sum = 0;
        foreach (var number in elements)
        {
            sum += number;
        }
        double average = sum / elements.Length;
        return average;
    }

    static int Sum(params int[] elements)
    {
        int sum = 0;
        foreach (var number in elements)
        {
            sum += number;
        }
        return sum;
    }

    static int Product(params int[] elements)
    {
        int product = 1;
        foreach (var number in elements)
        {
            product *= number;
        }
        return product;
    }
}
