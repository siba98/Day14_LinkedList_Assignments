using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_LinkedList_Assignments
{
    class UC5_DeleteFirstElement
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
            Console.WriteLine("{0} inserted into the Linked list", node.data);
        }

        internal Node RemoveFirstElement()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
        }
    }
}
