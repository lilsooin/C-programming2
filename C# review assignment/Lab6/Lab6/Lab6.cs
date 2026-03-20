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
            int col = data.GetLength(0); // 5
            int row = data.GetLength(1); // 6

            int[,] rotated = new int[row, col]; // 6, 5

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    rotated[i, j] = data[col - 1 - j, i];
                    // 0,0 <- 4, 0
                    // 0,1 <- 3, 0
                    // 0,2 <- 2, 0
                    // ...
                    // 1,0 <- 4, 1
                    //
                }
            }

            return rotated;
        }

        public static void TransformArray(int[,] data, EMode eMode)
        {
            // 2중 for문을 한 번 더 안 쓰고 세팅하는 법 없을까?
            // 있다
            int row = data.GetLength(0);
            int col = data.GetLength(1);

            int temp;

            switch (eMode)
            {
                case EMode.HorizontalMirror:
                    for (int i = 0; i < row; ++i)
                    {
                        for (int j = 0; j < col; ++j)
                        {
                            temp = data[i, col - 1 - j];
                            data[i, j] = temp;

                        }
                    }

                    break;

                case EMode.VerticalMirror:
                    for (int j = 0; j < col; ++j)
                    {
                        for (int i = 0; i < row / 2; ++i)
                        {
                            temp = data[i, j];
                            data[i, j] = data[i, row - 1 - j];
                            data[i, row - 1 - j] = temp;
                        }
                    }

                    break;

                case EMode.DiagonalShift:
                    for (int i = 0; i < col; ++i)
                    {
                        for (int j = 0; j < row; ++j)
                        {
                            temp = data[(i + 1) % col, (j + 1) % row];
                            data[i, j] = temp;
                        }
                    }

                    break;

                default: break;
            }
        }
    }
}