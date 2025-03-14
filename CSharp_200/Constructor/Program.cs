﻿namespace Constructor
{
    class Date
    {
        private int year, month, day;

        public Date()
        {
            year = 1;
            month = 1;
            day = 1;
        }

        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(2000, 11, 22);
            Date christmas = new Date(2018, 12, 25);
            Date firstDay = new Date();

            birthday.PrintDate();
            christmas.PrintDate();
            firstDay.PrintDate();
        }
    }
}
