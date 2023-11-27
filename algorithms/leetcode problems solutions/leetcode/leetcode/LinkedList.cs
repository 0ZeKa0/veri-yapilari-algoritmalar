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

         void addToEnd(int data)
        {
            SingleNode curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = new SingleNode(data);
        }
        void addToFront(int data)
        {

        }
    }
}
