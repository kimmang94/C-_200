namespace DivideByzero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Divide 에러 발생
            //int x = 10, y = 0;
            //Console.WriteLine(10.0 / y);
            //Console.WriteLine(x/ y);

            int x = 10, y = 0;

            try
            {
                Console.WriteLine(x / y);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
