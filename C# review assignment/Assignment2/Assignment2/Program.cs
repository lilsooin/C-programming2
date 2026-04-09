using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            printCanvas(Canvas.Draw(6, 9, EShape.Rectangle));
        }

        // canvas를 콘솔 창에 출력해주는 도우미 함수
        private static void printCanvas(char[,] canvas)
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
