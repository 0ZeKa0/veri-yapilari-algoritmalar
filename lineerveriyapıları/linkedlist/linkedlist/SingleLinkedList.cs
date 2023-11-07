using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class SingleLinkedList
    {
        public Node head;
        public int count = 0;
        public SingleLinkedList()
        {
            head = null;
        }

        public void InsertFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
            count++;
        }

        public void PrintSingleLinkedList() {

            Node runner = head;
            while(runner != null) {
                Console.WriteLine(runner.data); 
                runner = runner.next;

            }
        
        }
    }
}
