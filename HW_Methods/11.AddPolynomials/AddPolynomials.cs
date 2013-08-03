//11.Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 

using System;

public class AddPolynomials
{
    static void Main()
    {
        Console.WriteLine("Sum of two polynomials.");
        int[] input1 = { 0, -5, 6, 0, -4, 2 };
        int[] input2 = { 5, 0, 1, -3, 6 };

        PrintPolynomials(input1);
        Console.Write(" + ");
        PrintPolynomials(input2);
        Console.WriteLine();
        Console.WriteLine(new string('-',60));
        PrintPolynomials(SumPolynomials(input1, input2));
        Console.WriteLine();
    }

    public static void PrintPolynomials(int[] input1)
    {
        Console.Write("(");
        for (int i = input1.Length - 1; i >= 0; i--)
        {
            if (i > 1)
            {
                if (input1[i] != 0 && input1[i] != 1 && input1[i] != -1)
                {
                    Console.Write(input1[i] > 0 ? "+{0}x{1} " : "{0}x{1} ", input1[i], i);
                }
                if (input1[i] == 1) Console.Write("+x{0} ", i);
                if (input1[i] == -1) Console.Write("-x{0} ", i);

            }
            else if (i == 1)
            {
                if (input1[i] != 0 && input1[i] != 1 && input1[i] != -1)
                {
                    Console.Write(input1[i] > 0 ? "+{0}x " : "{0}x ", input1[i]);
                }
                if (input1[i] == 1) Console.Write("+x ");
                if (input1[i] == -1) Console.Write("-x " );

            }
            else
            {
                if (input1[i] != 0)
                {
                    Console.Write(input1[i] > 0 ? "+{0}" : "{0}", input1[i]);
                }

            }
        }
            Console.Write(")");
        
    }

    public static int[] SumPolynomials(int[] inp1, int[] inp2)
    {
       
        int maxLength , minLength ;
        int[] maxarr;
        int[] minarr;
        if (inp1.Length<inp2.Length)
        {
            maxLength = inp2.Length;
            minLength = inp1.Length;
            maxarr = (int[])inp2.Clone();
            minarr = (int[])inp1.Clone();
        }
        else
        {
            maxLength = inp1.Length;
            minLength = inp2.Length;
            maxarr = (int[])inp1.Clone();
            minarr = (int[])inp2.Clone();
        }
        int[] result = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            if (i<minLength)
            {
                result[i] = maxarr[i] + minarr[i];
            }
            else
            {
                result[i] = maxarr[i];
            }
        }
        return result;
    }
}
