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
                Console.WriteLine("Yes,Serached Value Found");
            else
                Console.WriteLine("Searched Value Not Found");

            #endregion



            #region UC8_InsertAtParticularPosition

            UC8_InsertAtParticularPosition list0 = new UC8_InsertAtParticularPosition();
            list0.Add(56);
            list0.Add(30);
            list0.Add(70);
            list0.InsertAtParticularPosition(3, 40);
            list0.Display();

            #endregion



            #region UC9_Delete_ShowListSize

            UC9_Delete_ShowListSize list9 = new UC9_Delete_ShowListSize();
            list9.Add(56);
            list9.Add(30);
            list9.Add(70);
            list9.InsertAtParticularPosition(2, 40);
            if (list9.Search(list9.head, 40))
                Console.WriteLine("Yes,Serached Value Found");
            else
                Console.WriteLine("Searched Value Not Found");

            #endregion
        }
    }
}
