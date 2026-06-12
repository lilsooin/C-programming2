using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.outparameterModifier
{
    class OutParameterModifier
    {
        public static void OutParameterModifierRun()
        {
            Console.WriteLine("Enter \"true\" or \"false\":");

            string booleanString = Console.ReadLine();

            bool b;
            if (bool.TryParse(booleanString, out b))
            {
                Console.WriteLine($"Sucessfully parsed: {b}");
            } 
            else
            {
                Console.WriteLine("Cannot be parsed to boolean");
            }

            Console.WriteLine("Enter an integer:");
            string intString = Console.ReadLine();

            int number;
            if (int.TryParse(intString, out number))
            {
                Console.WriteLine($"Sucessfully parsed: {number}");
                
            }
            else
            {
                Console.WriteLine("Cannot be parsed to integer");
            }

            int someNumber = 5;

            int randomNumber;
            if (TryGetIntegerGreaterThan(someNumber, out randomNumber))
            {
                Console.WriteLine($"Great! {randomNumber} > {someNumber}");
            }
            else
            {
                Console.WriteLine($"Failed to get an integer greater than {someNumber}");
            }

        }

        static bool TryGetIntegerGreaterThan(int intput, out int output)
        {
            var random = new Random();

            output = random.Next(0, 10);

            return output > intput;
        }
    }
}
