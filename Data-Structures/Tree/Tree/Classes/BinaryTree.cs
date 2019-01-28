using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        //create a list so that it can adjust dynamically
        public List<int> arrayofInts = new List<int>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Look at the root first
        /// </summary>
        /// <param name="root"></param>
        /// <returns>array of integers</returns>
        public int[] PreOrder(Node root)
        {
            //output = root.value
            arrayofInts.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }

            return arrayofInts.ToArray();
        }

        /// <summary>
        /// return children first and roots in between
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        public int[] InOrder(Node root)
        {
            if(root.LeftChild != null)
            {
                InOrder(root.LeftChild);
            }

            arrayofInts.Add(root.Value);

            if(root.RightChild != null)
            {
                InOrder(root.RightChild);
            }

            return arrayofInts.ToArray();
        }

        /// <summary>
        /// returns children first and root last
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        public int[] PostOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
            }

            arrayofInts.Add(root.Value);

            return arrayofInts.ToArray();
        }
    }
}
