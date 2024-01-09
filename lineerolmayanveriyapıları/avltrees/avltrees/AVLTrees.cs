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

        public AVLNode Insert(AVLNode node, int data)
        {
            //Girilen veriden başka bir veri yoksa bu veri ağaçtaki root olur.
            if(node == null)
                return new AVLNode(data);


            if (data < node.Data)
                node.Left = Insert(node.Left, data);
            else if (data > node.Data)
                node.Right = Insert(node.Right, data);
            else
                return node;

            node.Height = 1 + Math.Max(Height(node.Left),Height(node.Right));

            int balance = GetBalanced(node);

            if(balance>1&&data<node.Left.Data)
                return RightRotation(node);

            if(balance< -1 && data>node.Right.Data)
                return LeftRotation(node);

            //iki tane iç içe rotasyon işlemi yapıldı.
            if (balance > 1 && data > node.Left.Data && data<node.Right.Data)
            {
                node.Left=LeftRotation(node.Left);
                return RightRotation(node);
            }

            //Burada da iki iç içe rotasyon işlemi yapıldı.
            if(balance< -1 && data < node.Right.Data && data>node.Left.Data)
            {
                node.Right = RightRotation(node.Right);
                return LeftRotation(node);
            }

            return node;
        }

        public void Insert(int data)
        {
            root=Insert(root, data);
        }

        private void InOrderTraversal(AVLNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Data+" ");
                InOrderTraversal(node.Right);
            }
        }
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

    }
}
