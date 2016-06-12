using System;
using System.Collections;
using System.Collections.Generic;

namespace GraphTest
{
    interface ICleverGraph<T> : IEnumerable<T>, IEnumerable
    {
        IEnumerable<Tuple<T, T>> Edges { get; }
        int EdgesCount { get; }
        IEnumerable<T> Nodes { get; }
        int NodesCount { get; }

        void AddEdge(T from, T to);
        void AddNode(T node);
        IEnumerable<T> GetChildNodes(T node);
        IEnumerable<T> GetParentNodes(T node);
        bool HasEdge(T from, T to);
        bool HasNode(T node);
        bool RemoveEdge(T from, T to);
        bool RemoveNode(T node);
    }
}