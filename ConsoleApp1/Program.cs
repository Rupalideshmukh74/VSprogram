using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;

            Console.Write(" Addition : " + addition);
            Console.Write(" Subtraction : " + subtraction);

        }
    }
}
