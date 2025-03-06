namespace LinkedList_
{
    internal class Program
    {
        class Node
        {
            internal int data;
            internal Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        class LinkedList
        {
            Node head;

            internal void InsertFront(int data)
            {
                Node node = new Node(data);
                node.next = head;
                head = node;
            }

            internal void insertLast(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                    return;
                }
                Node lastNode = GetLastNode();
                lastNode.next = node; 
            }

            internal Node GetLastNode()
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            internal void InsertAfter (int prev, int data)
            {
                Node prevNode = null;

                for (Node temp = head; temp != null; temp = temp.next)
                {
                    if (temp.data == prev)
                    {
                        prevNode = temp;
                    }
                }

                if (prevNode == null)
                {
                    Console.WriteLine("{0} data is not in the list");
                    return;
                }
                Node node = new Node(data);
                node.next = prevNode.next;
                prevNode.next = node;
            }

            internal void DeleteNode(int key)
            {
                Node temp = head;
                Node prev = null;
                if (temp != null && temp.data ==key)
                {
                    head = temp.next;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }

            internal void Reverse()
            {
                Node prev = null;
                Node current = head;
                Node temp = null;
                while (current != null)
                {
                    temp = current.next;
                    current.next = prev;
                    prev = current;
                    current = temp;
                }
                head = prev;
            }

            internal void Print()
            {
                for (Node node = head; node != null; node = node.next )
                {
                    Console.Write(node.data + " -> ");
                }
                Console.WriteLine();
            }
        }

        

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Random r = new Random();

            for (int i = 0; i <  5; i++)
            {
                list.insertLast(r.Next(100));

                Console.WriteLine("랜덤한 5개 값의 리스트입니다.");
                list.Print();

                Console.Write("\n 맨 앞에 10, 맨 뒤에 90 삽입. <Enter> 입력하세요");
                Console.ReadLine();
                list.InsertFront(10);
                list.insertLast(90);
                list.Print();

                Console.WriteLine("\n x노드 뒤에 y 값을 저장하려고 합니다");
                Console.Write(" x값을 입력하세요 : ");
                int x = int.Parse(Console.ReadLine());
                Console.Write(" y값을 입력하세요 : ");
                int y = int.Parse(Console.ReadLine());

                list.InsertAfter(x, y);
                list.Print();

                Console.Write("\n 삭제할 노드의 값을 입력하세요 : ");
                int z = int.Parse(Console.ReadLine());
                list.DeleteNode(z);
                list.Print();

                Console.WriteLine("\n 리스트를 뒤집어 출력. <Enter> 입력하세요");
                Console.ReadLine();
                list.Reverse();
                list.Print();
            }
        }
    }
}
