using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    /// <summary>
    /// Implementation class
    /// </summary>
    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            this.head = null;
        }
        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        /// <summary>
        /// Appends the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        internal void Append(int item)
        {
            Node node = new Node(item);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} appended to the linked list", node.data);
        }
        /// <summary>
        /// Inserts the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="item">The item.</param>
        internal void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                try
                {
                    while (position > 2)
                    {
                        temp = temp.next;
                        position--;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
                catch (NullReferenceException)
                {
                    System.Console.WriteLine("Index out of bounds");
                }
            }
        }
        /// <summary>
        /// Deletes element at the beginning
        /// </summary>
        /// <returns></returns>
        internal Node Pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return null;
            }
            else
            {
                Node popped = head;
                head = head.next;
                return popped;
            }
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            if (head == null)
                System.Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + "\n");
                    temp = temp.next;
                }
            }
        }
    }
}
