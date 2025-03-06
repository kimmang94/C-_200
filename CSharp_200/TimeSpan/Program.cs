﻿namespace TimeSpan_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime chaistmas = new DateTime(2018, 12, 25);
            DateTime newYearsDay = new DateTime(2019, 1, 1);

            TimeSpan span = newYearsDay - chaistmas;
            Console.WriteLine("크리스마스와 1월 1일의 시간 간격");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days",span.Days );
            Console.WriteLine("{0,14} houser", span.Hours);
            Console.WriteLine("{0,14} minutes", span.Minutes);
            Console.WriteLine("{0,14} seconds", span.Seconds);
            Console.WriteLine("{0,14} milliseconds", span.Milliseconds);

            Console.WriteLine("또는");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.TotalDays);
            Console.WriteLine("{0,14} houser", span.TotalHours);
            Console.WriteLine("{0,14} minutes", span.TotalMinutes);
            Console.WriteLine("{0,14} seconds", span.TotalSeconds);
            Console.WriteLine("{0,14} milliseconds", span.TotalMilliseconds);
            Console.WriteLine("{0,14} ticks", span.Ticks);
        }
    }
}
