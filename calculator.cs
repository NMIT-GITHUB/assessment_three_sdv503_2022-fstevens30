using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tp - Power");
            Console.WriteLine("\tr - Remainder");
            Console.WriteLine("Enter your operator: ");
            string op = Console.ReadLine();
            double result = 0;
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    result = num1 / num2;
                    break;
                case "p":
                    result = Math.Pow(num1, num2);
                    break;
                case "r":
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator input");
                    break;

            }
            Console.WriteLine("Your result is: ");
            Console.WriteLine(result);
        }
    }
}
