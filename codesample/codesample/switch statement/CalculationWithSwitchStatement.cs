using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.switch_statment
{
    internal class CalculationWithSwitchStatement
    {
        public static void CalculationWithSwitchStatementRun()
        {
            Console.Write("num1: ");
            string num1String = Console.ReadLine();
            int num1 = int.Parse(num1String);

            Console.Write("num2: ");
            string num2String = Console.ReadLine();
            int num2 = int.Parse(num2String);

            Console.Write("operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                default:
                    Console.WriteLine($"You entered a wrong operator: {operation}");
                    break;
            }
        }
    }
}
