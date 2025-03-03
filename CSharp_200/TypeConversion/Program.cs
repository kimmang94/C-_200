namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2137483647;
            long bigNum = num;
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;
            Console.WriteLine(a);
        }
    }
}
