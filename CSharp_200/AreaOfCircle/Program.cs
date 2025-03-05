namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (double r = 1; r <= 10; r++)
            {
                Console.WriteLine("Area of cicle with radius {0,2} = {1,7:F2}", r, AreaOfCicle(r));
            }
        }

        private static double AreaOfCicle(double r)
        {
            return Math.PI * r * r;
        }
    }
}
