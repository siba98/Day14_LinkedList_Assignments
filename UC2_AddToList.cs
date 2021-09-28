using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_LinkedList_Assignments
{
    class UC2_AddToList
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
            Console.WriteLine("{0} inserted into the Linked List", node.data);
        }
    }
}
