namespace BinaryTree
{
    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(int value)
        {
            this.value = value;
        }

        public void Insert(int value)
        {
            if (this.value >= value)
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
            else
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
        }
    }
}