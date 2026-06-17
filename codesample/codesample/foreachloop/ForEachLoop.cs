using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.foreachloop
{
    class ForEachLoop
    {
        public static void ForEachLoopRun()
        {
            List<int> list = new List<int>();
            
            Random random = new Random();

            for (int i = 0; i < 20;  i++)
            {
                int number = random.Next(0, 10);
                list.Add(number);
            }

            int sum = 0; 

            foreach(int i in list) 
            {
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine("-------------------------------------");

            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                {"key1", 1 },
                {"key2", 2 },
                {"key3", 3 },
                {"key4", 4 },
                {"key5", 5 },
                {"key6", 6 },
            };
   
            foreach (KeyValuePair<string, int> entry in dictionary) 
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
