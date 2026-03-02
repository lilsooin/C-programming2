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
                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
                else if (usersPerDay[i] > 100)
                {
                    double revenue = (int)((usersPerDay[i] * usersPerDay[i] / 4.0 - 2 * usersPerDay[i] - 2007) * 100 + 0.5) / 100.0;
                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
                else if (usersPerDay[i] > 10)
                {
                    double revenue = (int)((16 * usersPerDay[i] / 5.0 - 27) * 100 + 0.5) / 100.0;
                    if (revenuePerDay[i] != revenue)
                    {
                        revenuePerDay[i] = revenue;
                        bFixed = true;
                    }
                }
                else
                {
                    double revenue = (int)((usersPerDay[i] / 2.0) * 100 + 0.5) / 100.0;
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
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }

            int count = 0;
            double[] expectedRevenue = new double[revenuePerDay.Length];
           
            for (int i = 0; i < usersPerDay.Length; ++i)
            {
                if (usersPerDay[i] > 1000)
                {
                    expectedRevenue[i] = 245743 + usersPerDay[i] / 4.0;
                }
                else if (usersPerDay[i] > 100)
                {
                    expectedRevenue[i] = usersPerDay[i] * usersPerDay[i] / 4.0 - 2 * usersPerDay[i] - 2007;
                }
                else if (usersPerDay[i] > 10)
                {
                    expectedRevenue[i] = 16 * usersPerDay[i] / 5.0 - 27;
                }
                else
                {
                    expectedRevenue[i] = usersPerDay[i] / 2.0;
                }

                if (revenuePerDay[i] != expectedRevenue[i])
                {
                    revenuePerDay[i] = (int)(expectedRevenue[i] * 100 + 0.5) / 100.0;
                    ++count;
                }
            }

            return count;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            if (revenuePerDay.Length == 0 || start >= end || end > revenuePerDay.Length - 1)
            {
                return -1;
            }

            double totalRevenue = 0.0;

            for (uint i = start; i <= end; ++i)
            {
                totalRevenue += revenuePerDay[i];
            }
       
            Console.WriteLine("totalRevenue > " + totalRevenue);
            return totalRevenue;
        }
    }
}

