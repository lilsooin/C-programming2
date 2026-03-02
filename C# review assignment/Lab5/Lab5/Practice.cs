using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Practice
    {
        public static void Square(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }
        }

        public static void PrintMultiplicationTable(uint num)
        {
            uint[,] table = new uint[num, 9];
            for (uint i = 0; i < num; ++i)
            {
                for (uint j = 0; j < 9; ++j)
                {
                    table[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{i + 1} X {j + 1} = {(i + 1) * (j + 1),-4}");
                    // Console.Write(table[j, i]);
                }

                Console.WriteLine();
            }
        }

        public static int FindIndex(int n, int[] nums)
        {
            for (int i = 0; n < nums.Length; n++)
            {
                if (nums[i] == n)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool HasNum(int n, int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] == n)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static int GetBiggestDifference(int[] nums)
        {
            int biggestDifference = 0;
            for (int i = 0; i <= nums.Length; ++i)
            {
                int difference = nums[i] - nums[i + 1];
                if (difference > biggestDifference)
                {
                    biggestDifference = difference;
                }
            }

            return biggestDifference;
        }

        // 6
        public static bool IsParentesisValid(string str)
        {
            int openCount = 0;
            int closeCount = 0;

            for (int i = 0; i < str.Length; ++i)
            {
                // 유효하지 않는 괄호 수에 대한 처리?
                if (closeCount > openCount)
                {
                    return false;
                }

                if (str[i] == '(')
                {
                    ++openCount;
                }
                else if (str[i] == ')')
                {
                    ++closeCount;
                }
            }

            if (openCount == closeCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 7
        public static uint Compare(int[] nums1, in uint[] nums2)
        {
            uint count = 0;
            for (int i = 0; i < nums1.Length; ++i)
            {
                if (nums1[i] == nums2[i])
                {
                    ++count;
                }
            }

            return count;
        }

        // 8

    }
}
