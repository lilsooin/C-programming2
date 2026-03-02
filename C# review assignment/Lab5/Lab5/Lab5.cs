using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            bool bFixed = false;

            for (int i = 0; i < usersPerDay.Length; ++i)
            {
                if (usersPerDay[i] > 1000)
                {
                    double revenue = (int)((245743 + usersPerDay[i] / 4.0) * 100 + 0.5) / 100.0;
                    Console.WriteLine($"revenue: {revenue}");

                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
                else if (usersPerDay[i] > 100)
                {
                    double revenue = (int)((usersPerDay[i] * usersPerDay[i] / 4.0 - 2 * usersPerDay[i] - 2007) * 100 + 0.5) / 100.0;

                    Console.WriteLine($"revenue: {revenue}");
                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
                else if (usersPerDay[i] > 10)
                {
                    double revenue = (int)((16 * usersPerDay[i] / 5.0 - 27) * 100 + 0.5) / 100.0;
                    Console.WriteLine($"revenue: {revenue}");
                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
                else
                {
                    double revenue = (int)((usersPerDay[i] / 2.0) * 100 + 0.5) / 100.0;
                    Console.WriteLine($"revenue: {revenue}");

                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
            }

            return bFixed;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            return -1;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            return 0.0;
        }
    }
}

