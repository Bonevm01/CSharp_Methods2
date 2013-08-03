//10.Write a program to calculate n! for each n in the range [1..100].
//  Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;

class Factoriel
{
    static int[] myarray = { 1 };
    static void Main()
    {

        for (int i = 1; i <= 100; i++)
        {
            Console.Write("{0}!= ", i);
            PrintArray(MultipArrAndInt(myarray, i));
        }

    }

    static int[] MultipArrAndInt(int[] arr, int a)
    {
        string aa = a.ToString();
        int[] tempor = new int[arr.Length + aa.Length];
        int decad = 0;
        do
        {
            int prenos = 0;
            int help = a % 10;
            int j = 0;
            for (int i = decad; i < arr.Length; i++)
            {
                int tempsum = tempor[i] + arr[j] * help + prenos;
                tempor[i] = (tempsum) % 10;
                prenos = (tempsum) / 10;
                j++;
            }
            for (int i = arr.Length; i < tempor.Length; i++)
            {
                if (j < arr.Length)
                {
                    int tempsum = tempor[i] + help * arr[j] + prenos;
                    tempor[i] = (tempsum) % 10;
                    prenos = (tempsum) / 10;
                    j++;
                }

                else
                {
                    int tempsum = tempor[i] + prenos;
                    tempor[i] = tempsum % 10; ;
                    prenos = tempsum / 10;
                }
            }
            decad++;
            a /= 10;

        } while (a > 0);

        return DeleteLeadingZeros(tempor);
    }

    static void PrintArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}", array[i]);
        }
        Console.WriteLine();
    }

    static int[] DeleteLeadingZeros(int[] array)
    {
        int length = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == 0)
            {
                length++;
            }
            else
            {
                break;
            }
        }
        if (length > 0)
        {
            myarray = new int[array.Length - length];

            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = array[i];
            }
        }
        else
        {
            myarray = (int[])array.Clone();
        }
        return myarray;
    }

}
