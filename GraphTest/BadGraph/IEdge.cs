namespace GraphTest
{
    public interface IEdge
    {
        INode FromNode { get; }
        INode ToNode { get; }

        bool IsDirected { get; }
    }
}
