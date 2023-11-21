using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Circledlinkedlist
{
    public class CircularDoublyLinkedList
    {
        DoubledNode last;

        public CircularDoublyLinkedList()
        {
            this.last = last;
            if (this.last != null)
            {
                this.last.next = last;
                this.last.prev = last;
            }
        }

        public void AddtoEnd(int data)
        {
            DoubledNode newNode = new DoubledNode(data);
            if (last==null) {
                newNode.next = newNode;
                newNode.prev = newNode;
            }
            else
            {
                newNode.next = last.next;
                last.next = newNode;
                newNode.prev = last;
            }
            last = newNode;

        }

        public void AddtoStart(int data)
        {
            DoubledNode newNode = new DoubledNode(data);
            if (last == null)
            {
                newNode.next = newNode;
                newNode.prev = newNode;
            }
            else
            {
                newNode.next = last.next;
                last.next = newNode;
                newNode.prev = last;
            }
            last = newNode;

        }

        // Problemim bütün listenin silinmesi
        //problem çözüldü
        public void RemovefromEnd() 
        {
            DoubledNode toDelete=last;
            DoubledNode prevNode = last.prev;
            DoubledNode first = last.next;

            if (last.next==null || last.prev==null || last==null)
            {
                last = null;
            }
            else
            {
               
                prevNode.next = last.next;
                first.prev = prevNode;
                last.next = null;
                last.prev = null;
            }
            
            last = prevNode;
            
        }

        public void RemovefromStart() 
        {
            DoubledNode toDelete = last;
            DoubledNode prevNode = last.prev;
            DoubledNode first = last.next;

            if (last.next == null || last.prev == null || last == null)
            {
                last = null;
            }
            else
            {

                prevNode.next = last.next;
                first.prev = prevNode;
                last.next = null;
                last.prev = null;
            }

            last = prevNode;
        }

        public void Print()
        {
            DoubledNode curr = last;

            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }
    }
}
