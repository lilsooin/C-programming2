using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace codesample.function
{
    class FunctionOverLoading
    {
        public static void Foo()
        {
            Console.WriteLine("Foo with no arguments.");
        }

        public static void Foo(int x)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {x} as an argument.");
        }

        //static int Foo(int x)
        //{
        //  return x + 1;
        //}

        public static void Foo(string s)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {s} as an argument.");
        }

        public static void Foo(string s1, string s2, string s3)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {s1}," +
                $"{typeof(int).Name}: {s2} and" +
                $"{typeof(int).Name}: {s3} as an argument.");
        }
    }
}
