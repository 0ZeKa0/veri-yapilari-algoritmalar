using linkedlist;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.InsertFront(2);
            list.InsertFront(3);
            list.InsertFront(4);
            list.PrintSingleLinkedList();
        }
    }
}