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
            linkedList.Add(56);
            linkedList.Add(70);
            //linkedList.Display();
            linkedList.Insert(2, 30);
           linkedList.Display();
        }
    }
}
