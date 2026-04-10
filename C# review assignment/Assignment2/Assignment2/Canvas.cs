using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            if (width == 0 || height == 0)
            {
                return new char[0, 0];
            }

            uint padding = 4;
            uint newWidth = width + padding;
            uint newHeight = height + padding;

            char[,] canvas = new char[newHeight, newWidth];
            Console.WriteLine("width > " + width);

            switch (shape)
            {
                case EShape.Rectangle:
                    for (int i = 0; i < newHeight; ++i)
                    {
                        for (int j = 0; j < newWidth; ++j)
                        {
                            if (i == 0 || i == newHeight - 1)
                            {
                                canvas[i, j] = '-';
                            }
                            else if (j == 0 || j == newWidth - 1)
                            {
                                canvas[i, j] = '|';
                            }
                            else if (j == 1 || j == newWidth - 2 || i == 1 || i == newHeight - 2)
                            {
                                canvas[i, j] = ' ';
                            }
                            else
                            {
                                canvas[i, j] = '*';
                            }
                        }
                    }

                    break;

                case EShape.IsoscelesRightTriangle:
                    if (width != height)
                    {
                        return new char[0, 0];
                    }

                    for (int i = 0; i < newHeight; ++i)
                    {
                        for (int j = 0; j < newWidth; ++j)
                        {
                            if (i == 0 || i == newHeight - 1)
                            {
                                canvas[i, j] = '-';
                            }
                            else if (j == 0 || j == newWidth - 1)
                            {
                                canvas[i, j] = '|';
                            }
                            else if (j == 1 || j == newWidth - 2 || i == 1 || i == newHeight - 2)
                            {
                                canvas[i, j] = ' ';
                            }
                            else if (j > i)
                            {
                                canvas[i, j] = ' ';
                            }
                            else
                            {
                                canvas[i, j] = '*';
                            }
                        }
                    }
                    break;

                case EShape.IsoscelesTriangle:
                    if (width != height * 2 - 1)
                    {
                        return new char[0, 0];
                    }

                    for (int i = 0; i < newHeight; ++i)
                    {
                        for (int j = 0; j < newWidth; ++j)
                        {
                            if (i == 0 || i == newHeight - 1)
                            {
                                canvas[i, j] = '-';
                            }
                            else if (j == 0 || j == newWidth - 1)
                            {
                                canvas[i, j] = '|';
                            }
                            else if (j == 1 || j == newWidth - 2 || i == 1 || i == newHeight - 2)
                            {
                                canvas[i, j] = ' ';
                            }
                            else if (j < (newWidth / 2) + (-i + 2) || j > (newWidth / 2) + (i - 2))
                            {
                                // 

                                // width / 2 = 6
                                // 13 / 2 - 1
                                // 9, 5
                                // newWidth / 2 = a + 1

                                // 왼쪽부분
                                // a2 = a + (n - 1) * 1
                                // 6 = 5 + 1
                                // a3 = 5 + 2
                                // - 1 + (i - 1) * 2

                                // 오른쪽부분
                                // a2 = a + 1 * -1
                                // a2 = 6
                                // a = 7
                                // 7 + (3 - 1) * -1
                                // a3 = 7 -2

                                // j > 6 || j < 6

                                // j < 5 || j > 7

                                // j < 4 || j > 8

                                // i = 3
                                // j = 5, 6, 7

                                // i = 4
                                // j = 4, 5, 6, 7, 8
                                // ...

                                canvas[i, j] = ' ';
                            }
                            else
                            {
                                canvas[i, j] = '*';
                            }
                        }
                    }


                    break;
                case EShape.Circle:
                    break;

                default:
                    Console.WriteLine("somthing wrong");
                    break;

            }



            return canvas;
        }
    }
}
