using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.recursive
{
    public class Recursive
    {
        public static void RecursiveRun()
        {
            const ulong FACTORIAL = 10;

            Console.WriteLine("NonRecursiveFactorial:");
            Console.WriteLine(NonRecursiveFactorial(FACTORIAL));

            Console.WriteLine("RecursiveFactorial:");
            Console.WriteLine(RecursiveFactorial(FACTORIAL));
        }

        static ulong NonRecursiveFactorial(ulong n)
        {
            if (n <= 1)
            {
                return 1;
            }

            uint factorial = 1;

            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static ulong RecursiveFactorial(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }

            return RecursiveFactorial(n - 1) * n;
        }
    }
}
