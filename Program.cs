using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating simple linked list
            Node head = new Node(56);
            head.next = new Node(30);
            head.next.next = new Node(70);
        }
    }
}
