//13. Write a program that can solve these tasks:
//    Reverses the digits of a number
//    Calculates the average of a sequence of integers
//    Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//    The decimal number should be non-negative
//    The sequence should not be empty
//    a should not be equal to 0
    
using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("The following program could solve three type of tasks:");
        Console.WriteLine("1 - Reverse the digits of a number.");
        Console.WriteLine("2 - Calculate the average of a sequence of integers.");
        Console.WriteLine("3 - Solves a linear equation a*x + b = 0.");
        Console.WriteLine(new string('-', 70));
        Console.Write("Which task's type do you want o solve? Please chofse 1,2 or 3-->");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (input == 1)
        {
            bool rightChoice;
            int result;
            do
            {
                Console.Write("Please enter a positive decimal number:");
                string number = Console.ReadLine();
                rightChoice = int.TryParse(number, out result);
            } while (!rightChoice || result < 0);

            RevDigits.ReverseDigits(result);
        }

        else if (input == 2)
        {
            string integers = "";
            Console.WriteLine("The average is {0}.", CalculateAverage(integers));
        }
        else if (input == 3)
        {
            double a, b;
            string coefA = "";
            bool rightChoice;
            do
            {
                Console.Write("Please enter the coeficient a (a<>0): ");
                coefA = Console.ReadLine();
                rightChoice = double.TryParse(coefA, out a);
            } while (!rightChoice || a == 0);
            Console.Write("Please enter the coeficient b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("The answer of equation {0}x+{1}=0 is {2}.", a, b, SolveLinearEquation(a,b));
        }
    }

    static double CalculateAverage(string str)
    {
        string integers;
        string[] elements;
        int[] numbers;
        bool rightChoice;
        do
        {
            Console.Write("Please enter some integers separated by space (example: 1 23 6):");
            integers = Console.ReadLine();
            elements = integers.Split(' ');
            numbers = new int[elements.Length];
            rightChoice = int.TryParse(elements[0], out numbers[0]);
        } while (!rightChoice);
        double sum = numbers[0];
        if (elements.Length > 1)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(elements[i]);
                sum += numbers[i];
            }
        }

        double result = sum / numbers.Length;
        return result;
    }

    static double SolveLinearEquation(double a, double b)
    {
        double result = -b / a;
        return result;
    }
}
