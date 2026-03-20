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

        public static void TransformArray(int[,] data, EMode eMode)
        {
            // 2중 for문을 한 번 더 안 쓰고 세팅하는 법 없을까?
            int col = data.GetLength(0);
            int row = data.GetLength(1);

            int[,] temp = new int[col, row];

            switch (eMode)
            {
                case EMode.HorizontalMirror:
                    for (int i = 0; i < col; ++i)
                    {
                        for (int j = 0; j < row; ++j)
                        {
                            temp[i, row - 1 - j] = data[i, j];
                        }
                    }

                    break;

                case EMode.VerticalMirror:
                    for (int j = 0; j < col; ++j)
                    {
                        for (int i = 0; i < row; ++i)
                        {
                            temp[col - 1 - j, i] = data[j, i];
                        }
                    }

                    break;

                case EMode.DiagonalShift:
                    break;

                default: break;
            }

            for (int i = 0; i < col; ++i)
            {
                for (int j = 0; j < row; ++j)
                {
                    data[i, j] = temp[i, j];
                }
            }
        }
    }
}