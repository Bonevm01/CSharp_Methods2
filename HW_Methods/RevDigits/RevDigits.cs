//7.Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

public class RevDigits
{
    public static void ReverseDigits(decimal a)
    {
        
        if (a<0)
        {
            string textNumber = a.ToString();
            char[] reversedNumber = new char[textNumber.Length-1];
            
            for (int i = textNumber.Length - 1; i >= 1; i--)
            {
                reversedNumber[textNumber.Length-1-i] =  textNumber[i];
            }
            string newNumber = new string(reversedNumber);
            decimal newNum = decimal.Parse(newNumber);  //To delete leading zeros
           Console.WriteLine("The reversed number looks--> -{0}", newNum);
        }
        else
        {
            string textNumber = a.ToString();
            char[] reversedNumber = new char[textNumber.Length];

            for (int i = textNumber.Length - 1; i >= 0; i--)
            {
                reversedNumber[textNumber.Length - 1 - i] = textNumber[i];
            }
            string newNumber = new string(reversedNumber);
            decimal newNum = decimal.Parse(newNumber);  //To delete leading zeros
            Console.WriteLine("The reversed number looks--> {0}", newNum);
        }

    }
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());
        ReverseDigits(input);
    }
}
