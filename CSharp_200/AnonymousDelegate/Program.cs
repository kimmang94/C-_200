﻿using System.Threading.Tasks.Sources;

namespace AnonymousDelegate
{
    internal class Program
    {
        delegate bool MembetTest(int x);
        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

            int n = Count(arr, delegate (int x) { return x % 2 == 0; });
            Console.WriteLine("짝수의 갯수 : " + n);

            n = Count(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine("홀수의 갯수 : " + n);
        }

        private static int Count(int[] arr, MembetTest testMethod)
        {
            int cnt = 0;
            foreach (var n in arr)
            {
                if (testMethod(n))
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}
