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
            for (int i = 0; i < nums.Length; i++)
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
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                int difference = nums[i + 1] - nums[i];
                if (difference > biggestDifference)
                {
                    biggestDifference = difference;
                }
            }

            return biggestDifference;
        }

        // 6
        public static bool IsParenthesisValid(string str)
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

            if (openCount == closeCount && openCount != 0 && closeCount != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 7
        public static uint Compare(int[] nums1, int[] nums2)
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
        public static uint Compare2(int[] nums1, in uint[] nums2)
        {
            uint count = 0;

            if (nums1.Length == nums2.Length)
            {
                for (int i = 0; i < nums1.Length; ++i)
                {
                    if (nums1[i] == nums2[i])
                    {
                        ++count;
                    }
                }
            }
            else
            {
                if (nums1.Length > nums2.Length)
                {

                    for (int i = 0; i < nums2.Length; ++i)
                    {
                        if (nums1[i] == nums2[i])
                        {
                            ++count;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < nums1.Length; ++i)
                    {
                        if (nums1[i] == nums2[i])
                        {
                            ++count;
                        }
                    }
                }
            }

            return count;
        }

        // 9
        public static void SumEachColumn(int[,] nums)
        {

            for (int j = 0; j < nums.GetLength(1); ++j)
            {
                int sum = 0;
               
                for (int i = 0; i < nums.GetLength(0); ++i)
                {
                    sum += nums[i, j];
                }

                nums[nums.GetLength(0) - 1, j] = sum;
            }
        }

        // 10
        public static void GetLabel(int[,] voltorbFlips, int[] outNumColumns, int[] outNumRows, int[] outVoltorbColumns, int[] outVoltorbRow)
        {
            for (int i = 0; i < voltorbFlips.GetLength(0); i++)
            {
                int outNums = 0;

                for (int j = 0; j < voltorbFlips.GetLength(1); j++)
                {
                    // 근데 이거 5x5일 때만 가능할 듯
                    outNumColumns[i] += voltorbFlips[j, i];
                    outNumRows[i] += voltorbFlips[i, j];

                    if (voltorbFlips[j, i] == 0)
                    {
                        ++outVoltorbColumns[j];
                    }

                    if (voltorbFlips[i, j] == 0)
                    {
                        ++outVoltorbRow[i];
                    }

                }
            }
        }
    }
}
