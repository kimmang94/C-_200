namespace Obejct_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = i + 10;
            int j = (int)o;


            Console.WriteLine("The value-type value i = {0}" , i);
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = 0;
            o = 100;
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The object -tye value p = {0}", p);
        }
    }
}
