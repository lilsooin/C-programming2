using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.loop
{
    internal class Sum
    {
        public static void SumRun()
        {
            const int MAX = 100;
            Console.WriteLine($"Sum of 1 - {MAX}");

            int sum = 0;
            for (int i = 0; i < MAX; ++i)
            {
                sum += (i + 1);
            }

            Console.WriteLine(sum);
        }
    }
}
