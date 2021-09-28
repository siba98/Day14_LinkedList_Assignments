using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_LinkedList_Assignments
{
    class UC7_Search
    {
        internal Node head; //new
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal bool Search(Node head, int x)
        {
            Node current = head; // Initialize current
            while (current != null)
            {
                if (current.data == x)
                    return true; // data found
                current = current.next;
            }
            return false; // data not found
        }
    }
}
