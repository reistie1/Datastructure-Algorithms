using System;
using System.Collections.Generic;
using System.Linq;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;

namespace DatastructureAlgorithms.WeightedGraphs
{
    public class Subset<T> where T : class {
        public GraphNode<T> Parent;
        public int Rank;
    }

    public class WeightedGraph<T> where T : class
    {
        public List<GraphNode<T>> _nodeSet;
        public int VerticesCount;
        public int EdgeCount;
        public WeightedGraph()
        {
        }

        public GraphNode<T> AddNode(T value)
        {
            GraphNode<T> newNode = new GraphNode<T>(value);
            if(Find(newNode) != null)
            {
                return null;
            }
            else
            {
                _nodeSet.Add(newNode);
                return newNode;
            }
        }

        public void UpdateIndices()
        {
            int i = 0;
            _nodeSet.ForEach(c => c.Index = i++);
        }
        public bool AddEdge(GraphNode<T> sourceNode, GraphNode<T> destinationNode, int weight)
        {
            GraphNode<T> source = Find(sourceNode);
            GraphNode<T> destination = Find(destinationNode);

            if(source == null || destination == null)
            {
                return false;
            }
            else if(source.connections.Contains(destination))
            {
                return false;
            }
            else
            {
                sourceNode.AddConnection(destinationNode);
                destinationNode.AddConnection(sourceNode);
            }

            return true;
        }

        public GraphNode<T> Find(GraphNode<T> inputNode)
        {
            foreach(var node in _nodeSet)
            {
                if(node.Equals(inputNode))
                {
                    return node;
                }
            }
            return null;
        }

        public void Union(Subset<T>[] subsets, GraphNode<T> from, GraphNode<T> to)
        {
            if(subsets[from.Index].Rank > subsets[to.Index].Rank)
            {
                subsets[to.Index].Parent = from;
            }
            else if(subsets[from.Index].Rank < subsets[to.Index].Rank)
            {
                subsets[from.Index].Parent = to;
            }
            else
            {
                subsets[to.Index].Parent = from;
                subsets[from.Index].Rank++;
            }
        }

        public GraphNode<T> GetRoot(Subset<T>[] subsets, GraphNode<T> node)
        {
            if(subsets[node.Index].Parent != node)
            {
                subsets[node.Index].Parent = GetRoot(subsets, subsets[node.Index].Parent);
            }

            return subsets[node.Index].Parent;
        }

        public List<GraphEdge<T>> GetEdges()
        {
            List<GraphEdge<T>> edges = new List<GraphEdge<T>>();
            foreach(var node in _nodeSet)
            {
                for(var i = 0; i < node.GetNodeConnections().Count; i++)
                {
                    GraphEdge<T> newEdge = new GraphEdge<T>(node, node.connections[i]);
                    edges.Add(newEdge);
                }
            } 

            return edges;
        }

        public List<GraphEdge<T>> KruskalAlgorithm()
        {
            List<GraphEdge<T>> edges = GetEdges();
            edges.Sort((a,b) => a.GetWeight().CompareTo(b.GetWeight()));
            Queue<GraphEdge<T>> queue = new Queue<GraphEdge<T>>(edges);

            Subset<T>[] subsets = new Subset<T>[_nodeSet.Count];
            for(var j = 0; j < _nodeSet.Count; j++)
            {
                subsets[j] = new Subset<T>() { Parent = _nodeSet[j] };
            }

            List<GraphEdge<T>> result = new List<GraphEdge<T>>();
            while(result.Count < _nodeSet.Count - 1)
            {
                GraphEdge<T> edge = queue.Dequeue();
                GraphNode<T> from = GetRoot(subsets, edge.GetSource());
                GraphNode<T> to = GetRoot(subsets, edge.GetDestination());
                if(from != to)
                {
                    result.Add(edge);
                    Union(subsets, from, to);
                }
            }
            return result;
        }
    }
}