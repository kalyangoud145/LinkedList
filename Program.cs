using System;

namespace LinkedListProject
{
    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList sortedLinkedList =  new SortedLinkedList();
            sortedLinkedList.Add(70);
            sortedLinkedList.Add(30);
            sortedLinkedList.Add(56);
            sortedLinkedList.Add(40);
            sortedLinkedList.Display();
        }
    }
}
