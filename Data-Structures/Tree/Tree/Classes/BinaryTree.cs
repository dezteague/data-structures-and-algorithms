using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node node)
        {
            Root = node;
        }

        //preOrder
        public void PreOrder(Node root)
        {
            //output = root.value

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
        }
            
        //inOrder
        public void InOrder(Node root)
        {
            if(root.LeftChild != null)
            {
                InOrder(root.LeftChild);
            }
            
            //output = root.value

            if(root.RightChild != null)
            {
                InOrder(root.RightChild);
            }
        }

        //postOrder
        public void PostOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
            }

            //output = root.value
        }
    }
}
