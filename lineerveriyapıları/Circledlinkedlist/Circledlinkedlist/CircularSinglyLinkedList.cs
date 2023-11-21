using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Circledlinkedlist
{
    public class CircularSinglyLinkedList
    {
        SingledNode last;

        //yapıcıyı oluşturduk. Yapıcı direkt circled işlemini yapacak.
        public CircularSinglyLinkedList()
        {
            this.last = last;
            if(this.last != null)
            {
                this.last.next = last;
            }
        }

        public void addToEnd(int data)
        {
            SingledNode singledNode= new SingledNode(data);
            
            if(last == null)
            {
                singledNode.next = singledNode;
            }
            else
            {
                singledNode.next = last.next;
                last.next = singledNode;
            }
            last = singledNode;
        }

        public void addToStart(int data)
        {
            SingledNode singledNode = new SingledNode(data);
            if (last == null)
            {
                singledNode.next= singledNode;
                last = singledNode;
            }
            else
            {
                singledNode.next = last.next;
                last.next= singledNode;
            }
        }

        public void deleteLast(int data)
        {
            SingledNode toDelete = last;

            if(toDelete.next == null || last == null)
            {
                last = null;
            }

            SingledNode prev = last.next;

            while (prev.next!=null)
            {
                prev = prev.next;
            }
            prev.next = last.next;
            prev = last;
        }

        public void deleteStart(int data)
        {
            SingledNode toDelete = last;

            if (last == null || last.next == null)
            {
                last = null;
            }

            toDelete = last.next;
            last.next = toDelete.next;
        }

        public void Print()
        {
            SingledNode curr = last;

            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }


    }
}
