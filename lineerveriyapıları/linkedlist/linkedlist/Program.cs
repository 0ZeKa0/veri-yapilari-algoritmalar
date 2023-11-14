using linkedlist;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();

            Console.WriteLine("InserFront işlemi ile listeye sırayla 2 3 4 4 4 sayıları eklendi. \t ");
            list.InsertFront(2);
            list.InsertFront(3);
            list.InsertFront(4);
            list.InsertFront(4);
            list.InsertFront(4);
            list.PrintSingleLinkedList();
            Console.WriteLine("Insertback işlemi ile listeye sırayla 45 8 9 34 89 sayıları eklendi. \t ");
            list.InsertBack(45);
            list.InsertBack(8);
            list.InsertBack(9);
            list.InsertBack(34);
            list.InsertBack(89);
            list.PrintSingleLinkedList();
            Console.WriteLine("RemoveFront işlemi listenin başından 4 eleman silindi. \t ");
            for (int i = 0; i < 4; i++)
            {
                list.RemoveFront();
            }
            list.PrintSingleLinkedList();
            Console.WriteLine("RemoveFront işlemi listenin sonundan 2 eleman silindi. \t ");
            for(int i = 0;i < 2; i++)
            {
                list.RemoveBack();
            }
            list.PrintSingleLinkedList();

        }
    }
}