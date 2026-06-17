using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.dictionary
{
    class DictionaryExample
    {
        public static void DictionaryExampleRun()
        {
            List<int> list = new List<int>(20);

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(0, 10);
                list.Add(number);

                Console.WriteLine($"[ {string.Join(",", list)}]");
            }

            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();

            for (int i = 0; i < list.Count; i++)
            {
                if (dictionary.ContainsKey(list[i]))
                {
                    list.Remove(list[i]);
                }
                else
                {
                    dictionary.Add(list[i], true);
                }
            }

            Console.WriteLine($"[ {string.Join(",", list)}]");
        }
    }
}
