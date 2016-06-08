using System;
using System.Collections;
using System.Collections.Generic;

namespace GraphTest
{
	class StupidGraph<T> : IGraph
	{
		public List<Node<T>> Nodes { get; private set; }
		IEnumerable<INode> IGraph.Nodes => new List<INode>(Nodes);

		public List<Edge<T>> Edges { get; private set; }
		IEnumerable<IEdge> IGraph.Edges => new List<IEdge>(Edges);

		int IGraph.NodesCount => Nodes.Count;

		void IGraph.AddNode(INode node)
		{
			var nodeGen = node as Node<T>;

			if(nodeGen == null)
				throw new ArgumentException("Node used is incompatible. Use supplied type Node<T>.");

			Nodes.Add(nodeGen);
		}

		void AddEdge(INode from, INode to, bool directed)
		{
			var fromGen = from as Node<T>;
			var toGen = to as Node<T>;

			if(fromGen == null || toGen == null)
				throw new ArgumentException("Nodes used are incompatible. Use supplied type Node<T>.");

			// TODO
			// Check if the graph has the nodes.

			Edges.Add(new Edge<T>(fromGen, toGen, directed));
		}

        void IGraph.AddDirectedEdge(INode from, INode to) => AddEdge(from, to, true);

        void IGraph.AddUndirectedEdge(INode node1, INode node2) => AddEdge(node1, node2, false);

        IEnumerable<INode> IGraph.GetAdjacentNodes(INode node)
		{
			throw new NotImplementedException();
		}

		IEnumerable<INode> IGraph.GetChildNodes(INode node)
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator<INode> IEnumerable<INode>.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerable<INode> IGraph.GetParentNodes(INode node)
		{
			throw new NotImplementedException();
		}

		bool IGraph.HasDirectedEdge(INode from, INode to)
		{
			throw new NotImplementedException();
		}

		bool IGraph.HasEdge(IEdge edge)
		{
			var edgeGen = edge as Edge<T>;

			if(edgeGen == null)
				throw new ArgumentException("Node used is incompatible. Use supplied type Edge<T>.");

			foreach(Edge<T> n in Edges)
			{
                // TODO
			}

			return false;
		}

		bool IGraph.HasNode(INode node)
		{
			var nodeGen = node as Node<T>;

			if(nodeGen == null)
				throw new ArgumentException("Node used is incompatible. Use supplied type Node<T>.");

			foreach(var n in Nodes)
				if(n.Id == nodeGen.Id)
					return true;

			return false;
		}

		bool IGraph.HasUndirectedEdge(INode node1, INode node2)
		{
			throw new NotImplementedException();
		}

		bool IGraph.RemoveDirectedEdge(INode from, INode to)
		{
			throw new NotImplementedException();
		}

		bool IGraph.RemoveEdge(IEdge edge)
		{
			throw new NotImplementedException();
		}

		bool IGraph.RemoveUndirectedEdge(INode node1, INode node2)
		{
			throw new NotImplementedException();
		}
	}
}
