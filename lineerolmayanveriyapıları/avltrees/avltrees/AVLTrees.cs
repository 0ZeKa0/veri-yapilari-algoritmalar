using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avltrees
{
    public class AVLTrees
    {
        private  AVLNode root;

        public AVLTrees() {
            root = null;
        }

        private int Height( AVLNode node )
        {
            if ( node == null )
            
                return 0;
    
            return node.Height;
        }

        private int GetBalanced( AVLNode node )
        {
            if( node == null ) return 0;
            return Height(node.Left)-Height(node.Right);
        }

        private AVLNode RightRotation( AVLNode node )
        {
            AVLNode x= node.Left;
            AVLNode T1=x.Right;

            x.Right = node;
            node.Left = T1;

            node.Height = Math.Max(Height(node.Left),Height(node.Right))+1;
            x.Height = Math.Max(Height(x.Left),Height(x.Right)) + 1;

            return node;
        }

        private AVLNode LeftRotation( AVLNode node ) {
            AVLNode x = node.Right;
            AVLNode T1 = x.Left;

            x.Left = node;
            node.Right = T1;

            node.Height=Math.Max(Height(node.Right),Height(node.Left)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

            return node;
        }


    }
}
