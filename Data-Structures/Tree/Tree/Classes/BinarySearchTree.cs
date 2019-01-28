namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        //add(value)
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

        //contains(value)
        public bool Contains(int value)
        {
            if (Root.Value == value)
            {
                return true;
            }

            if (value < Root.Value)
            {
                Root = LeftChild;
            }
            else
            {
                Root = RightChild;
            }
        }
       
    }
}
