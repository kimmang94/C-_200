﻿namespace FloatDoubleDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);
            Console.WriteLine("float : {0} bytes\ndouble : {1} bytes\ndecimal : {2} bytes", sizeof(float), sizeof(double), sizeof(decimal));
            Console.WriteLine("float : {0} ~ {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double : {0} ~ {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0} ~ {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
