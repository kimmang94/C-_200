﻿namespace IsLeapYear_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2001 ~ 2100년 사이의 윤년을 찾는 프로그램
            for (int year = 2001; year <= 2100; year++)
            {
                if (IsLeepYear(year))
                {
                    Console.Write("{0} ", year);
                }
            }
            Console.WriteLine();
        }

        private static bool IsLeepYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
