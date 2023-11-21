using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circledlinkedlist
{
    public class DoubledNode
    {
        public int data;
        public DoubledNode next;
        public DoubledNode prev;

        public DoubledNode(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
