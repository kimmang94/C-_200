using System.Collections;

namespace SortArrPair
{
    internal class Program
    {
        public class ReverseComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                string s1 = (string)x;
                string s2 = (string)y;
                return string.Compare(s2, s1);
            }
        }
        static void Main(string[] args)
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse"};
            string[] animalsKo = { "개", "소", "토끼", "염소", "양", "쥐" };
            Display("Beffore Sort", animalsEn, animalsKo);

            Array.Sort(animalsEn, animalsKo);
            Display("After Sort", animalsEn, animalsKo);

            Array.Sort(animalsKo, animalsEn);
            Display("After Sort by Korean", animalsEn, animalsKo);

            IComparer revCom = new ReverseComparer();
            Array.Sort(animalsEn, animalsKo, revCom);
            Display("After Descending Sort", animalsEn, animalsKo);

        }

        public static void Display(string cmt, string[] a1, string[] a2)
        {
            Console.WriteLine(cmt);
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("[{0}] : {1,-8} {2, -8}", i, a1[i], a2[i]);
            }
            Console.WriteLine();
        }
    }
}
