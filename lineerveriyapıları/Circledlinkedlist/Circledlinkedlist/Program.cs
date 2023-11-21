
using Circledlinkedlist;

namespace CircledLinkedList
{
    class CircledLinkedList
    {
        static void Main(string[] args)
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.AddtoEnd(3);
            list.AddtoEnd(4);
            list.AddtoEnd(5);
            list.AddtoEnd(6);
            list.AddtoEnd(7);
            list.RemovefromEnd();
            list.Print();
        }
    }
}