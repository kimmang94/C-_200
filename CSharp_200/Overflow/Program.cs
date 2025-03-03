namespace Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            //int x = int.MaxValue, y = 0;
            //y = x + 10;
            //Console.WriteLine("int.MaxValue + 10 = {0}", y);

            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("int.MaxValue + 10 = {0}", y);
            }
        }
    }
}
