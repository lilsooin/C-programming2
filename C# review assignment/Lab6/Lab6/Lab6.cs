using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] data)
        {
            int[,] newData = new int[data.GetLength(1), data.GetLength(0)];
            Console.WriteLine("newData.GetLength(0) > " + newData.GetLength(0));
            Console.WriteLine("newData.GetLength(1) > " + newData.GetLength(1));

            for (int i = 0; i < data.GetLength(0); ++i)
            {
                // 0, 0 ->  0,5
                // 0, 1 ->  1,5
                // 0, 2 ->  2,5
                // 0, 3 ->  3,5
                // 0, 4 ->  4,5
                // 0, 5 ->  5,5
                // 1, 0 -> 

                for (int j = 0; j < data.GetLength(1); ++j)
                {
                    Console.WriteLine("data.GetLength(0) > " + data.GetLength(0));
                    Console.WriteLine("data.GetLength(1) > " + data.GetLength(1));
                    Console.WriteLine("i >" + i);
                    Console.WriteLine("j >" + j);
                    Console.WriteLine("data.GetLength(0) 1 - i > " + (data.GetLength(0) - 1 - i));
                    Console.WriteLine("data.GetLength(1) 1 - j > " + (data.GetLength(1) - 1 - j));

                    newData[i, j] = data[data.GetLength(0) - 1 - i, data.GetLength(1) - 1 - j];
                    //Console.WriteLine("newData: " + newData[i, data.GetLength(0) - 1 - j]);
                }
            }

            return newData;
        }
    }
}