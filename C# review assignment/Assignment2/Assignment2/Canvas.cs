using System;
using System.Collections.Generic;
using System.Linq;
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

            char[,] canvas = new char[height, width];
            Console.WriteLine("width > " + width);

            switch (shape)
            {
                case EShape.Rectangle:
                    for (int i = 0; i < height; ++i)
                    {
                        for (int j = 0; j < width; ++j)
                        {
                            if (i == 0 || i == height - 1)
                            {
                                canvas[i, j] = '-';
                            }
                            else if (j == 0 || j == width - 1)
                            {
                                canvas[i, j] = '|';
                            }
                            else if (j == 1 || j == width - 2 || i == 1 || i == height - 2)
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
