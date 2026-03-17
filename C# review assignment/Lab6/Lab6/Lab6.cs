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
            int height = data.GetLength(0);
            int width = data.GetLength(1);
            Console.WriteLine("height > " + height); // 5
            Console.WriteLine("width > " + width);   // 6

            int[,] newData = new int[width, height];

            for (int i = 0; i < data.GetLength(0); ++i)
            {
                for (int j = 0; j < data.GetLength(1); ++j)
                {
                    newData[j, height - 1 - i] = data[i, j];
                }
            }

            return newData;
        }
    }
}