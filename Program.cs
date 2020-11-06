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
            linkedList.Delete(56);
            Console.WriteLine("Size of list is: "+linkedList.Size());
            linkedList.Display();

        }
    }
}
