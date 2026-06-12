using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.default_arugment
{
    class DefasultParameters
    {
        public static void DefaultParametersRun()
        {
            Bar("POCU");
            Bar("POCU", "COMP1500");
            Bar("POCU", "COMP1500", "Intro to Programming!");
        }

        static void Bar(string s, string s2 = "", string s3 = "")
        {
            Console.WriteLine($"{s}, {s2}, {s3}");
        }
    }
}
