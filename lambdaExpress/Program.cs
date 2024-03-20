using System;

namespace LambdaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double number2 = double.Parse(Console.ReadLine());

          
            var sum = (double x, double y) => x + y;
            
            var multiply = (double x, double y) => x * y;
            
            var min = (double x, double y) =>
            {
                if (x < y)
                    return x;
                else
                    return y;
            };

            Console.WriteLine($"Sum of {number1} and {number2} is {sum(number1, number2)}");
            Console.WriteLine($"Product of {number1} and {number2} is {multiply(number1, number2)}");
            Console.WriteLine($"Smaller value between {number1} and {number2} is {min(number1, number2)}");
        }
    }
}