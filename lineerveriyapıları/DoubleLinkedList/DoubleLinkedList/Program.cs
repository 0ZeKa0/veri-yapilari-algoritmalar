using DoubleLinkedList;
using System;

namespace HelloGeeksApp
{
    class HelloGeeks
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list =new DoublyLinkedList();
            Console.WriteLine("Başlangıca 2 3 ve 45 sayıları eklendi.");
            list.FrontAdd(2);
            list.FrontAdd(3);
            list.FrontAdd(45);
            list.PrintList();
            Console.WriteLine("Sona 43 ve 37 sayıları eklendi.");
            list.BackAdd(43);
            list.BackAdd(37);
            list.PrintList();
            Console.WriteLine("Baştan bir değer silindi.");
            list.DeleteNodeFront();
            list.PrintList();
            Console.WriteLine("Sondan bir değer silindi.");
            list.DeleteNodeEnd();
            list.PrintList();

        }
    }
}