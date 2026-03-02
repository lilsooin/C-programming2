using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] usersPerDay = new uint[7] { 3, 10, 66, 101, 657, 1032, 4520 };
            double[] revenuePerDay = new double[7] { 1.50, 5.00, 184.20, 341.25, 104591.25, 246001.00, 246873.00 };

            bool bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay);
        }
    }
}
