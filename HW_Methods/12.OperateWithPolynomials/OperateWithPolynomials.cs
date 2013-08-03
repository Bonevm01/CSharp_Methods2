//12. Extend the program from exercise 11 to support also subtraction and multiplication of polynomials.
// Methods Print and Sum Polinomials are refered to class AddPolinomials - ex11.

using System;

class OperateWithPolynomials
{
    static void Main()
    {
        int[] input1 = { 0, -5, 6, -1 };
        int[] input2 = { 5, -1, 2};
        Console.WriteLine("Sum of two polynomials.");
        AddPolynomials.PrintPolynomials(input1);// Method from class AddPolinomials - ex11.
        Console.Write(" + ");
        AddPolynomials.PrintPolynomials(input2);
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
        AddPolynomials.PrintPolynomials(AddPolynomials.SumPolynomials(input1, input2));// Methods from class AddPolinomials - ex11.
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Substraction of two polynomials.");
        AddPolynomials.PrintPolynomials(input1);
        Console.Write(" - ");
        AddPolynomials.PrintPolynomials(input2);
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
        AddPolynomials.PrintPolynomials(SubstractPolynomials(input1, input2));
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Multiplication of two polynomials.");
        AddPolynomials.PrintPolynomials(input1);
        Console.Write(" * ");
        AddPolynomials.PrintPolynomials(input2);
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        AddPolynomials.PrintPolynomials(MultiplyPolinomials(input1, input2));
        Console.WriteLine();
    }

    static int[] SubstractPolynomials(int[] inp1, int[] inp2)
    {
        int maxLength = Math.Max(inp1.Length, inp2.Length);
        int minLength = Math.Min(inp1.Length, inp2.Length);
        int[] result = new int[maxLength];
        if (inp1.Length < inp2.Length)
        {
            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    result[i] = inp1[i] - inp2[i];
                }
                else
                {
                    result[i] = -inp2[i];
                }
            }

        }
        else
        {
            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    result[i] = inp1[i] - inp2[i];
                }
                else
                {
                    result[i] = inp1[i];
                }
            }
        }
        return result;
    }

    static int[] MultiplyPolinomials(int[] inp1, int[] inp2)
    {
        int maxLength = Math.Max(inp1.Length, inp2.Length);
        int minLength = Math.Min(inp1.Length, inp2.Length);
        int[] result = new int[maxLength + minLength];
        if (inp1.Length > inp2.Length)
        {
            for (int i = 0; i < maxLength; i++)
            {
                for (int k = 0; k < minLength; k++)
                {
                    result[i + k] += inp1[i] * inp2[k];
                }

            }
        }
        else
        {
            for (int i = 0; i < maxLength; i++)
            {
                for (int k = 0; k < minLength; k++)
                {
                    result[i + k] += inp1[k] * inp2[i];
                }

            }
        }
        return result;
    }
}
