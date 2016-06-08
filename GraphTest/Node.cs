using System;

namespace GraphTest
{
	public class Node<T> : INode
	{
		public T Item { get; }
		public Guid Id { get; }

		Node()
		{
			Id = Guid.NewGuid();
		}

		public Node(T item) : this()
		{
			Item = item;
		}

		public Node(Node<T> node) : this()
		{
			Item = node.Item;
		}
	}
}