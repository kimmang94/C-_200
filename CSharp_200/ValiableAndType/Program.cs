namespace ValiableAndType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요 :");
            string name = Console.ReadLine();
            Console.WriteLine("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님! ");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는");
            Console.Write(height);
            Console.WriteLine("cm 이시군요!");


            // var 형
            // C# 3.0 부터 메소드 범위에서 선언된 지역변수에서 암시적 형식인 var 을 사용할 수 있다.
        }
    }
}
