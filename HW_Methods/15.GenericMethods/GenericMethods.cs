//15. * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
//    Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Threading;


class GenericMethods
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Console.WriteLine("Minimums:");
        Console.WriteLine(Minimum(-1.25, 5.21, 8.54));
        Console.WriteLine(Minimum(1.254643667537, 1.6543243132435453, 2.04654655446454));
        Console.WriteLine("Maximums:");
        Console.WriteLine(Maximun(-2, 3, 10));
        Console.WriteLine(Maximun(1.0574, 24.04541, -1254.05));
        Console.WriteLine("Average:");
        Console.WriteLine(Average(1,3,5));
        Console.WriteLine(Average(1.04545124154, 2.0152454512154512421, 3.0152451214));
        Console.WriteLine("sum:");
        Console.WriteLine(Sum(1.0545454,2.0145400,3.04872));
        Console.WriteLine("Products:");
        Console.WriteLine(Product(1.11111,2.222222,3.22222));
    }

    static T Minimum<T>(params T[] elements)
    {
        dynamic min;
        dynamic zero = 0;
        int length = elements.Length;
        if (length > 0)
        {
            min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }
            return min;
        }
        else
        {
            return zero;
        }

    }

    static T Maximun<T>(params T[] elements)
    {
        dynamic max;
        dynamic zero = 0;
        int length = elements.Length;
        if (length > 0)
        {
            max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }
        else
        {
            return zero;
        }
    }

    static T Average<T>(params T[] elements)
    {
        dynamic sum = 0;
        int length = elements.Length;
        if (length > 0)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            dynamic average = sum / elements.Length;
            return average;
        }
        else
        {
            return sum;
        }

    }

    static T Sum<T>(params T[] elements)
    {
        dynamic sum = 0;
        foreach (var number in elements)
        {
            sum += number;
        }
        return sum;
    }

    static T Product<T>(params T[] elements)
    {
        dynamic product = 1;
        foreach (var number in elements)
        {
            product *= number;
        }
        return product;
    }
}
