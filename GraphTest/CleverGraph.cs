using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GraphTest
{
    public class CleverGraph<T> : ICleverGraph<T>
    {
        public CleverGraph() : this(EqualityComparer<T>.Default) { }
        public CleverGraph(IEqualityComparer<T> comparer)
        {
            Comparer = comparer ?? EqualityComparer<T>.Default;
            DataStorage = new Dictionary<T, HashSet<T>>(comparer);
        }

        IEqualityComparer<T> Comparer { get; }
        Dictionary<T, HashSet<T>> DataStorage { get; }

        public IEnumerable<T> Nodes => DataStorage.Keys;
        public void AddNode(T node) => DataStorage.Add(node, new HashSet<T>(Comparer));
        public bool HasNode(T node) => DataStorage.ContainsKey(node);
        public int NodesCount => DataStorage.Count;

        public bool RemoveNode(T node)
        {
            if(!HasNode(node))
                return false;

            var success = true;
            foreach(var pair in DataStorage)
                if(pair.Value.Contains(node))
                    success &= pair.Value.Remove(node);

            success &= DataStorage.Remove(node);
            return success;
        }

        public IEnumerable<Tuple<T, T>> Edges
        {
            get
            {
                // Assumes a directed graph. An undirected graph should be implemented differently.
                foreach(var pair in DataStorage)
                    foreach(var node in pair.Value)
                        yield return Tuple.Create(pair.Key, node);
            }
        }
        public int EdgesCount => Edges.Count();
        public void AddEdge(T from, T to)
        {
            if(HasNode(from) && HasNode(to))
                DataStorage[from].Add(to);
            else
                throw new InvalidOperationException("One of the two nodes is not in the Graph.");
        }
        public IEnumerable<T> GetChildNodes(T node) => DataStorage[node];
        public IEnumerable<T> GetParentNodes(T node)
            => Edges.Where(edge => Comparer.Equals(edge.Item2, node))
                    .Select(edge => edge.Item1);

        public bool HasEdge(T from, T to) => HasNode(from) && HasNode(to) && DataStorage[from].Contains(to);
        public bool RemoveEdge(T from, T to) => HasEdge(from, to) && DataStorage[from].Remove(to);

        public IEnumerator<T> GetEnumerator() => Nodes.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}