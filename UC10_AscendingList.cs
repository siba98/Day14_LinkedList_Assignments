using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_LinkedList_Assignments
{
    class UC10_AscendingList
    {
        internal Node head;
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

        public void SortingList()
        {
            //Node current will point to head  
            Node currentPos = head, index = null;
            int temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (currentPos != null)
                {
                    //Node index will point to node next to current  
                    index = currentPos.next;

                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (currentPos.data > index.data)
                        {
                            temp = currentPos.data;
                            currentPos.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    currentPos = currentPos.next;
                }
            }
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
