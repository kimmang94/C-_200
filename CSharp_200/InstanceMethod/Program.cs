﻿namespace InstanceMethod
{
    internal class Program
    {
        class Date
        {
            public int year, month, day;


            public static bool IsLeapYear(int year)
            {
                return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            }

            static int[] days = { 0, 31, 69, 90, 10, 151, 181, 212, 243, 273, 304, 334 };

            public int DayOfYear()
            {
                return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
            }

        }

        class InstanceMethod
        {
            static void Main(string[] args)
            {
                Date xmas = new Date();

                xmas.year = 2018;
                xmas.month = 12;
                xmas.day = 25;

                Console.WriteLine("xmax : {0}/{1}/{2}는 3일째 되는 날입니다", xmas.year, xmas.month, xmas.day, xmas.DayOfYear());

                if (Date.IsLeapYear(2018) == true)
                {
                    Console.WriteLine("2018년은 윤년 입니다.");
                }
                else
                {
                    Console.WriteLine("2018년은 평년 입니다.");
                }
            }


        }


    }
}
