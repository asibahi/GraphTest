namespace GraphTest
{
    public class Edge<T> : IEdge
    {
        public Node<T> FromNode { get; }
        public Node<T> ToNode { get; }
        public bool IsDirected { get; }

        INode IEdge.FromNode => new Node<T>(FromNode);
        INode IEdge.ToNode => new Node<T>(ToNode);
        bool IEdge.IsDirected => IsDirected;

        internal Edge(Node<T> from, Node<T> to, bool directed)
        {
            FromNode = from;
            ToNode = to;
            IsDirected = directed;
        }
    }
}
