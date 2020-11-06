using System;

namespace LinkedList
{
    /// <summary>
    /// Main class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Display();
        }
    }
}
