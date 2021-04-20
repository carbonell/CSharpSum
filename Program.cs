using System;

namespace CSharpSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Objective
            Console.WriteLine("Program to sum 2 numbers: ");

            // Requesting user Input

            // Requesting first Number
            Console.WriteLine("Insert first number: ");
            string number1String = Console.ReadLine();

            // Requesting second Number
            Console.WriteLine("Insert second number: ");
            string number2String = Console.ReadLine();

            // Converting numbers to decimal
            decimal number1 = Decimal.Parse(number1String);
            decimal number2 = Decimal.Parse(number2String);

            // Doing sum
            decimal sum = number1 + number2;
            Console.WriteLine("The sum of the numbers is " + sum);
        }
    }
}
