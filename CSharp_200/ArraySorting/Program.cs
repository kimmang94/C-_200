using System.Runtime.CompilerServices;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sord: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);

            Array.Sort(name);
            PrintArray("Ater Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
        }

        private static void PrintArray(string s, String[] name)
        {
            Console.WriteLine(s);
            foreach(var n in name)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine();
        }
    }
}
