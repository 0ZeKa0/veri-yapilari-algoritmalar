using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleLinkedList
    {
        public Node head;

        public void FrontAdd(DoubleLinkedList doubleLinkedList,int data)
        {
            Node newNode = new Node(data);
            newNode.next = doubleLinkedList.head;
            if(doubleLinkedList.head != null)
            {
                doubleLinkedList.head.next = newNode;
            }
            doubleLinkedList.head = newNode;


        }
        public void BackAdd(DoubleLinkedList doubleLinkedList,int data)
        {
            Node newNode = new Node(data);
            if(doubleLinkedList.head == null)
            {
                doubleLinkedList.head = newNode;
                return;
            }

            Node lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;

        }
        public Node GetLastNode(DoubleLinkedList doubleLinkedList)
        {
            Node temp = doubleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
