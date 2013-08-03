//1.Write a method that asks the user for his name and prints “Hello, <name>”
//  (for example, “Hello, Peter!”). Write a program to test this method.
using System;

namespace SayHello
{
    public class Greetings
    {

        public static string SayHello(string str)
        {
            string line = new string('-', 20);
            Console.WriteLine(line);
            string output = "Hello " + str + "!";//I made the method to return string in order to be able to test it.
            Console.WriteLine(output);
            return output;//I made the method to return string in order to be able to test it with unit tests

        }
        static void Main()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();//This part is out of the method in order to be able to test it with unit test
            SayHello(input);
        }
    }
}