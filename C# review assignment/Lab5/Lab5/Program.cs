using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_DAYS = 15;

            uint[] usersPerDay = new uint[NUMBER_OF_DAYS] { 0, 3, 5, 10, 34, 66, 89, 100, 101, 321, 657, 1000, 1032, 4520, 6578 };
            double[] revenuePerDay = new double[NUMBER_OF_DAYS] { 0, 1.50, 2.50, 5.00, 81.80, 184.20, 257.80, 293.00, 341.25, 23111.25, 104591.25, 245993.00, 246001.00, 246873.00, 247387.50 };

            bool bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay);
            Debug.Assert(!bFixed);

            revenuePerDay[0] = 10000.2;
            revenuePerDay[6] = 156;
            revenuePerDay[11] = 45628.34;

            bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay);
            Debug.Assert(bFixed);
            Debug.Assert(revenuePerDay[0] == 0);
            Debug.Assert(revenuePerDay[6] == 257.80);
            Debug.Assert(revenuePerDay[11] == 245993.00);

            int numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay);
            Debug.Assert(numInvalidEntries == 0);

            revenuePerDay[0] = 10000.2;
            revenuePerDay[6] = 156;
            revenuePerDay[11] = 45628.34;

            numInvalidEntries = Lab5.GetInvalidEntryCount(usersPerDay, revenuePerDay);
            Debug.Assert(numInvalidEntries == 3);

            const double epsilon = 0.001;

            /*double totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 5);
            Debug.Assert(Math.Abs(totalRevenue - 10275.2) <= epsilon);

            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 10, 14);
            Debug.Assert(Math.Abs(totalRevenue - 890481.09) <= epsilon);

            totalRevenue = Lab5.CalculateTotalRevenue(revenuePerDay, 0, 14);
            Debug.Assert(Math.Abs(totalRevenue - 924657.79) <= epsilon);*/

            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            Practice.Square(nums);

            Debug.Assert(nums[0] == 1);
            Debug.Assert(nums[1] == 4);

            Practice.PrintMultiplicationTable(5);

            // 배열 연습문제
            int[] testArray = new int[]
          {
                1,2,3
          };
            int[] testArray2 = new int[]
           {
                1,2,3
           };

            int[,] multiAray = new int[,]
            {
                {1,2,3},
                {4,5,6},
            };

            Practice.Square(testArray);

            Practice.PrintMultiplicationTable(9);

            Console.WriteLine(Practice.FindIndex(1, testArray2));

            Debug.Assert(Practice.FindIndex(1, testArray2) == 0);
            Debug.Assert(Practice.FindIndex(2, testArray2) == 1);
            Debug.Assert(Practice.FindIndex(3, testArray2) == 2);
            Debug.Assert(Practice.FindIndex(4, testArray2) == -1);
            Debug.Assert(Practice.FindIndex(100, testArray2) == -1);


            int[,] numss = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Debug.Assert(Practice.HasNum(2, numss) == true);
            Debug.Assert(Practice.HasNum(5, numss) == true);
            Debug.Assert(Practice.HasNum(9, numss) == false);
            Debug.Assert(Practice.HasNum(14, numss) == false);

            //Debug.Assert(HasNum(1, testArray2) == true);

            int[] nums1 = new int[5] { 2, 7, 14, 38, 41 };
            int[] nums2 = new int[5] { 6, 9, 13, 19, 40 };
            int[] nums3 = new int[5] { 3, 11, 16, 30, 33 };

            Debug.Assert(Practice.GetBiggestDifference(nums1) == 24);
            Debug.Assert(Practice.GetBiggestDifference(nums2) == 21);
            Debug.Assert(Practice.GetBiggestDifference(nums3) == 14);


            string str1 = "()()";
            string str2 = "()(a(bc))d()";
            string str3 = "(())))";
            string str4 = "(";
            string str5 = ")";
            string str6 = "(()";
            string str7 = ")()(";
            string str8 = "";

            Debug.Assert(Practice.IsParenthesisValid(str1) == true);
            Debug.Assert(Practice.IsParenthesisValid(str2) == true);
            Debug.Assert(Practice.IsParenthesisValid(str3) == false);
            Debug.Assert(Practice.IsParenthesisValid(str3) == false);
            Debug.Assert(Practice.IsParenthesisValid(str4) == false);
            Debug.Assert(Practice.IsParenthesisValid(str5) == false);
            Debug.Assert(Practice.IsParenthesisValid(str6) == false);
            Debug.Assert(Practice.IsParenthesisValid(str7) == false);
            Debug.Assert(Practice.IsParenthesisValid(str8) == false);

            int[] nums4 = new int[6] { 0, 1, 2, 3, 4, 5 };
            int[] nums5 = new int[9] { 5, 1, 2, 4, 3, 0, 2, 3, 9 };
            Debug.Assert(Practice.Compare(nums4, nums5) == 2);

            int[,] nums6 = new int[5, 5]
            {
                { 5, 9, 10, 33, 3 },
                { 12, 8, 98, 103, 22 },
                { 38, 29, 34, 11, 1 },
                { 5, 9 , 19, 38, 42 },
                { 0, 0, 0, 0, 0 }
            };

            Practice.SumEachColumn(nums6);

            Debug.Assert(nums6[4, 0] == 60);
            Debug.Assert(nums6[4, 1] == 55);
            Debug.Assert(nums6[4, 2] == 161);
            Debug.Assert(nums6[4, 3] == 185);
            Debug.Assert(nums6[4, 4] == 68);

            const int ROW_SIZE = 5;
            const int COLUMN_SIZE = 5;
            int[,] voltorbFlips = new int[ROW_SIZE, COLUMN_SIZE]
            {
            { 1, 1, 1, 3, 1 },
            { 1, 1, 1, 1, 0 },
            { 0, 3, 0, 0, 1 },
            { 3, 1, 1, 0, 1 },
            { 1, 1, 1, 0, 1 },
            };

            int[] outNumColumns = new int[5];
            int[] outVoltorColumns = new int[5];
            int[] outNumRows = new int[5];
            int[] outVoltorRows = new int[5];

            Practice.GetLabel(voltorbFlips, outNumColumns, outNumRows, outVoltorColumns, outVoltorRows);
            Debug.Assert(outNumRows[0] == 7);
            Debug.Assert(outNumRows[1] == 4);
            Debug.Assert(outNumRows[2] == 4);
            Debug.Assert(outNumRows[3] == 6);


            Debug.Assert(outVoltorColumns[2] == 1);
            Debug.Assert(outVoltorColumns[3] == 3);
            Debug.Assert(outVoltorColumns[4] == 1);


            Debug.Assert(outVoltorRows[0] == 0);
            Debug.Assert(outVoltorRows[1] == 1);
            Debug.Assert(outVoltorRows[2] == 3);
            Debug.Assert(outVoltorRows[3] == 1);
            Debug.Assert(outVoltorRows[3] == 1);

            Debug.Assert(outNumColumns[1] == 7);
            Debug.Assert(outNumColumns[2] == 4);
            Debug.Assert(outNumColumns[3] == 4);
        }
    }
}
