using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circledlinkedlist
{
    public class SingledNode
    {
        public int data;
        public SingledNode next;

        public SingledNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
