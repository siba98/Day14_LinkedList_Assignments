using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_LinkedList_Assignments
{
    class UC9_Delete_ShowListSize
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
            Console.WriteLine("\n{0} inserted into the linked list", node.data);
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

        internal void InsertAfter(Node prev_node, int new_data)
        {
            //Check if the given Node is null
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");

                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        internal void DeleteNode(int key)
        {
            // Store head node
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                // Changed head
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            // If key was not present in linked list
            if (temp == null)
                return;
            // Unlink the node from linked list
            prev.next = temp.next;
        }

        //Returns Count of Nodes in Linked List
        internal int ShowListSize()
        {
            Node temp = head;
            int count = 0; //Intializing as 0
            while (temp != null)
            {
                count++; // Count will be get adding
                temp = temp.next;
            }
            return count;
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
