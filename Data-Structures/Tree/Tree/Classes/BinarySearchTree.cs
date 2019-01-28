namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// add new node depending on whether the value is greater or less than the root
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns>node</returns>
        public Node Add(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = value;
            }
            else if (value < root.Value)
            {
                root.LeftChild = Add(root.LeftChild, value);
            }
            else
            {
                root.RightChild = Add(root.RightChild, value);
            }
            return root;
        }

        /// <summary>
        /// search tree for input value based on whether the value is greater or less than the root.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>boolean</returns>
        public bool Contains(int value)
        {
            if (Root.Value == value)
            {
                return true;
            }

            if (value < Root.Value)
            {
                Root = Root.LeftChild;
            }
            else
            {
                Root = Root.RightChild;
            }

            return false;
        }
       
    }
}
