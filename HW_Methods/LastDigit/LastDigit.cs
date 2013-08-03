//3.Write a method that returns the last digit of given integer as an English word.
//  Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigit
{
    static string SayLastDigit(int a)
    {
        string[] name = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return name[a % 10];
    }
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(SayLastDigit(input));
    }
}
