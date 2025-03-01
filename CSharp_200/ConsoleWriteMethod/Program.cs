namespace ConsoleWriteMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'A';
            decimal d = 1.234m;
            double e = 1.23456789;
            float f = 1.23456789f;
            int i = 1234;
            string s = "Hello";


            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);


            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3} ", 2,3,5,7);

            string primes;
            primes = String.Format("10 이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
