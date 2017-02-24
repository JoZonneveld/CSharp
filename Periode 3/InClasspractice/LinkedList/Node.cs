namespace LinkedList
{

    public class NodeOrEmpty
    {
        public bool IsEmpty;
    }

    public class Empty : NodeOrEmpty
    {
        public Empty()
        {
            this.IsEmpty = true;
        }
    }

    public class Node : NodeOrEmpty
    {
        public int Value;
        public NodeOrEmpty Tail;

        public Node(int value, NodeOrEmpty tail)
        {
            this.IsEmpty = false;
            this.Value = value;
            this.Tail = tail;
        }
    }
}