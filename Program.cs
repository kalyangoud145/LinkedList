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
            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Display();
            Console.WriteLine(linkedList.Search(312000));

        }
    }
}
