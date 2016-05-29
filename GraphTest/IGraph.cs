using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphTest
{
	// Immutable graph pls
	interface IGraph<T> : IEnumerable<T>
	{
		// Add a Node
		void AddNode(INode<T> node);

		// Create Node out of item and add it.
		void AddNode(T item);

		// Add Directed Edge
		void AddDirectedEdge(INode<T> from, INode<T> to);

		// Add Weighted Directed Edge
		void AddWeightedDirectedEdge(INode<T> from, INode<T> to, int weight);

		// Add Undirected Edge
		void AddUndirectedEdge(INode<T> node1, INode<T> node2);

		// Add Weighted Undirected Edge
		void AddWeightedUndirectedEdge(INode<T> node1, INode<T> node2, int weight);

		// Whether an Item exists or not
		bool Contains(T item);

		// Supply a Node or an Item and get Adjacent Nodes
		IEnumerable<INode<T>> GetAdjacentNodes(INode<T> node);
	}
}
