using System;

namespace Day14_LinkedList_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC2_AddToList

            UC2_AddToList list = new UC2_AddToList();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            #endregion



            #region UC3_Appending

            UC3_Appending list3 = new UC3_Appending();
            list3.Add(56);
            list3.append(30);
            list3.append(70);
            list3.Display();

            #endregion



            #region UC4_Insert

            UC4_Insert list4 = new UC4_Insert();
            list4.Add(56);
            list4.Insert(2, 30);
            list4.Add(70);
            list4.Display();

            #endregion



            #region UC5_DeleteFirstElement

            UC5_DeleteFirstElement list5 = new UC5_DeleteFirstElement();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.RemoveFirstElement();
            Console.WriteLine("\nFirst Element Removed\n");
            list5.Display();

            #endregion



            #region UC6_DeleteLastElement

            UC6_DeleteLastElement list6 = new UC6_DeleteLastElement();
            list6.Add(56);
            list6.Add(30);
            list6.Add(70);
            list6.RemoveLastElement();
            Console.WriteLine("\nLast Element Removed\n");
            list6.Display();

            #endregion



            #region UC7_Search

            UC7_Search list7 = new UC7_Search();
            list7.Add(56);
            list7.Add(30);
            list7.Add(70);
            if (list7.Search(list7.head, 30))
                Console.WriteLine("Yes,Searched Value(30) Found");
            else
                Console.WriteLine("Searched Value Not Found");

            #endregion



            #region UC8_InsertAtParticularPosition

            UC8_InsertAtParticularPosition list8 = new UC8_InsertAtParticularPosition();
            list8.Add(56);
            list8.Add(30);
            list8.Display();
            if (list8.Search(list8.head, 30))
            {
                Console.WriteLine("\nYes,Serached Value(30) Found");
                list8.InsertAfter(list8.head.next, 40);
                Console.WriteLine("\n40 Inserted After Searched Value(30)");
                list8.Display();
            }
            else
                Console.WriteLine("Searched Value Not Found");
            list8.Add(70);
            list8.Display();

            #endregion



            #region UC9_Delete_ShowListSize

            UC9_Delete_ShowListSize list9 = new UC9_Delete_ShowListSize();
            list9.Add(56);
            list9.Add(30);
            list9.Display();
            if (list9.Search(list9.head, 30))
            {
                Console.WriteLine("\nYes,Searched Value(30) Found");
                list9.InsertAfter(list9.head.next, 40);
                Console.WriteLine("\n40 Inserted After Searched Value(30)");
                list9.Display();
            }
            else
            {
                Console.WriteLine("Searched Value Not Found");
            }

            list9.Add(70);
            list9.Display();
            list9.DeleteNode(40);
            Console.WriteLine("\n40 Again Removed from List");
            list9.Display();
            Console.WriteLine("\nAfter Deleting the node the List Size is: " + list9.ShowListSize());

            #endregion



            #region

            UC10_AscendingList list10 = new UC10_AscendingList();
            list10.Add(56);
            list10.Add(30);
            list10.Add(40);
            list10.Add(70);
            Console.WriteLine("Linked List before Sorting..");
            list10.Display();
            Console.WriteLine("\nLinkedList After sorting");
            list10.Display();

            #endregion
        }
    }
}
