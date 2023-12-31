using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avltrees
{
    public class AVLNode
    {
        public int Data;
        public int Height;
        public AVLNode Left, Right;
        public AVLNode(int data) {
            Data = data;
            Height = 1;
            Left = Right = null;
         
        }
    }
}
