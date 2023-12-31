using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearch
    {
        Node root;
        public void insert(Node node) { 
        root=insertHelper(root, node);
        }
        private Node insertHelper(Node root, Node node)
        {
            int data = node.data;
            if (root==null)
            {
                root = node;
                return root;
            }
            else if (data<root.data )
            {
                root.left = insertHelper(root.left, node);
            }
            else
            {
                root.right=insertHelper(root.right, node);  
            }
            return root;
        }
        public void Displayinorder() {
            DisplayHelper(root);
        }
        public void Displaypreorder()
        {
            DisplayHelper2(root);
        }
        public void Displaypostorder()
        {
            DisplayHelper3(root);
        }
        //inorder traversal
        private void DisplayHelper(Node root) {
            if (root != null)
            {
                DisplayHelper(root.left);
                Console.WriteLine(root.data);
                DisplayHelper(root.right);
            }
        
        }
        private void DisplayHelper2(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                DisplayHelper(root.left); 
                DisplayHelper(root.right);
            }
        }
        private void DisplayHelper3(Node root)
        {
            if (root != null)
            {
                DisplayHelper(root.left);
                DisplayHelper(root.right);
                Console.WriteLine(root.data);
            }
        }
        public Boolean Search(int data) { 
            return SearchHelper(root,data); }
        private Boolean SearchHelper(Node root, int data)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.data == data)
            {
                return true;
            }
            else if(root.data > data)
            {
                 return SearchHelper(root.left, data); 
            }
            else
            {
                return SearchHelper(root.right, data);
            }
        }
        public void remove(int data) {

            if (Search(data))
            {
                RemoveHelper(root, data);
            }
            else
            {
                Console.WriteLine(data + "could not be found");
            }
        }
        public Node RemoveHelper(Node root, int data)
        {
            if(root == null)
            {
                return root;
            }
            else if (data < root.data)
            {
                root.left=RemoveHelper(root.left, data);
            }
            else if(data>root.data)
            {
                 root.right= RemoveHelper(root.right, data);  
            }
            else
            {
                if(root.left== null && root.right == null)
                {
                    root = null;
                }
                else if (root.right != null)
                {
                    root.data = Successor(root);
                    root.right = RemoveHelper(root.right, root.data);
                }
                else
                {
                    root.data = Predecessor(root);
                    root.left = RemoveHelper(root.right, root.data);
                }
            }
            return null;
        }

        //rootun sağ tarafındaki en küçük değeri bulur
        private int Successor(Node root)
        {
            root = root.right;
            while (root.left!=null)
            {
                root=root.left;
            }
            return root.data;
        }
        //rootun solundaki en büyük sayı bulunur
        private int Predecessor(Node root)
        {
            root = root.left;
            while (root.right != null)
            {
                root = root.right;
            }
            return root.data;
        }
    }
}
