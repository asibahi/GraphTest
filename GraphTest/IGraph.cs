using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphTest
{
	public interface IGraph : IEnumerable<INode>
	{
		// Main List
		IEnumerable<INode> Nodes { get; }
		IEnumerable<IEdge> Edges { get; }

		// Size of Graph
		int NodesCount { get; }

		// Supply a Node or an Item and get Adjacent Nodes
		IEnumerable<INode> GetAdjacentNodes(INode node);
		IEnumerable<INode> GetChildNodes(INode node);
		IEnumerable<INode> GetParentNodes(INode node);

		// Add a Node
		void AddNode(INode node);

		// Add Edge
		void AddDirectedEdge(INode from, INode to);
		void AddUndirectedEdge(INode node1, INode node2);

		// Remove Edge if exists. Returns false if doesn't exist.
		bool RemoveEdge(IEdge edge);
		bool RemoveDirectedEdge(INode from, INode to);
		bool RemoveUndirectedEdge(INode node1, INode node2);

		// Whether an Item exists or not
		bool HasNode(INode node);

		bool HasEdge(IEdge edge);
		bool HasDirectedEdge(INode from, INode to);
		bool HasUndirectedEdge(INode node1, INode node2);
	}
}
