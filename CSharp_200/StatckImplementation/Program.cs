namespace StatckImplementation
{
    internal class Program
    {
        class MyStack<T>
        {
            const int maxSize = 10;
            private T[] arr = new T[maxSize];
            private int top;

            public MyStack()
            {
                top = 0;
            }

            public void Push(T val)
            {
                if (top < maxSize)
                {
                    arr[top] = val;
                    ++top;
                }
                else
                {
                    Console.WriteLine("Stack Full");
                    return;
                }
            }
            public T Pop()
            {
                if (top > 0)
                {
                    --top;
                    return arr[top];
                }
                else
                {
                    Console.WriteLine("Stack Empty");
                    return default(T);
                }

            }
        }

     
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = r.Next(100);
                stack.Push(val);
                Console.Write("Push(" + val + ") ");
            }
            Console.WriteLine();

            Console.Write("Pop()="+ stack.Pop() + ",");
        }
    }
}
