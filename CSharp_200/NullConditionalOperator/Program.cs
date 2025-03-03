namespace NullConditionalOperator
{
    // null 이란 어떤 객체도 참조하지 않는 참조형 변수 이다.
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");

            do
            {
                LongNameAnimal(animal);
                Console.WriteLine("동물 이름 : ");

            } while ((animal = Console.ReadLine()) != "");
        }

        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4)
            {
                Console.WriteLine(animal + " : " + animal.Length);
            }
            else
            {
                Console.WriteLine("이름이 4글자 이상이 아닙니다.");
            }
        }
    }
}
