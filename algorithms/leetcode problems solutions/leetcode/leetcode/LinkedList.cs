using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetcode
{
    public class LinkedList
    {
        SingleNode head;

        
         public void addToEnd(int data)
        {
            if (head == null)
            {
                head = new SingleNode(data);
            }
            SingleNode curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = new SingleNode(data);
        }
        public void addToFront(int data)
        {
            SingleNode newNode = new SingleNode(data);

            if (head == null)
            {
                head = newNode;
            }
            newNode.next = head;
            head = newNode;
        }
        public void RemoveFromFront()
        {
            if(head!=null)
            {
                SingleNode toDelete = head;
                head=head.next;
            }
        }
        //son elemana ulaşmak için
        public int ReturnLastDigit()
        {
            int last=0;
            SingleNode curr = head;
            while (curr.next!=null)
            {
                curr=curr.next;
            }
            last = curr.data;

            return last;
        }
        public int ReturnHead()
        {
            if(head is not null)
            {
                SingleNode curr = head;
                return curr.data;
            }
            else { return 0; }
        }

        public void print()
        {
            SingleNode curr = head;
            while(curr.next!=null)
            {
                Console.WriteLine(curr.data);
                curr=curr.next;
            }
        }

        public int ReturnDataOfIndex(int flag)
        {
            SingleNode curr = head;
            for(int i=0; i < flag; i++)
            {
                curr = curr.next;
            }
            return curr.data;
        }
    }
}
