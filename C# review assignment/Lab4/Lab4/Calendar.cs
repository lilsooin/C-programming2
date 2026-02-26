using System;

namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            bool IsLeapYear;

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    IsLeapYear = false;
                }
            }
            else
            {
                IsLeapYear = false;
            }

            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            uint[] DaysOfMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            uint[] LeapDayOfMonths = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month > 12)
            {
                return -1;
            }

            if (IsLeapYear(year))
            {
                return LeapDayOfMonths[month - 1];
            }
            else
            {
                return DaysOfMonths[month - 1];
            }
        }
    }
}