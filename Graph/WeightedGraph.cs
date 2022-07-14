using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;
using DatastructureAlgorithms.Queue;

namespace DatastructureAlgorithms.WeightedGraphs
{
    public class Subset<T> where T : class {
        public GraphNode<T> Parent;
        public int Rank;
    }

    public class WeightedGraph<T> where T : class
    {
        public List<GraphNode<T>> _nodeSet;
        public List<GraphEdge<T>> _edgeSet;
        public int VerticesCount = 6; 
        public Dictionary<T, LinkedList<GraphNode<T>>> _adjacencyList;

        public int EdgeCount;
        public WeightedGraph()
        {
            _nodeSet = new List<GraphNode<T>>();
            _edgeSet = new List<GraphEdge<T>>();
            _adjacencyList = new Dictionary<T, LinkedList<GraphNode<T>>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public GraphNode<T> AddNode(T Value)
        {
            GraphNode<T> newNode = new GraphNode<T>(Value);
            if(Find(newNode) != null)
            {
                return null;
            }
            else
            {
                _nodeSet.Add(newNode);
                _adjacencyList.Add(Value, new LinkedList<GraphNode<T>>());
                UpdateIndices();
                return newNode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateIndices()
        {
            int i = 0;
            _nodeSet.ForEach(c => c.Index = i++);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceNode"></param>
        /// <param name="destinationNode"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
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
                _edgeSet.Add(new GraphEdge<T>(sourceNode, destinationNode, weight));
                
                _adjacencyList[sourceNode._identifier].AddLast(new LinkedListNode<GraphNode<T>>(new GraphNode<T>(destinationNode._identifier, weight)));
                _adjacencyList[destinationNode._identifier].AddLast(new LinkedListNode<GraphNode<T>>(new GraphNode<T>(sourceNode._identifier, weight)));
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputNode"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsets"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsets"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public GraphNode<T> GetRoot(Subset<T>[] subsets, GraphNode<T> node)
        {
            Console.WriteLine(node._identifier + " " + node.Index);
            if(subsets[node.Index].Parent != node)
            {
                subsets[node.Index].Parent = GetRoot(subsets, subsets[node.Index].Parent);
            }

            return subsets[node.Index].Parent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<GraphEdge<T>> KruskalAlgorithm()
        {
            List<GraphEdge<T>> edges = _edgeSet;
            edges.Sort((a,b) => a.GetWeight().CompareTo(b.GetWeight()));

            Subset<T>[] subsets = new Subset<T>[_nodeSet.Count];
            for(var j = 0; j < _nodeSet.Count; j++)
            {
                subsets[j] = new Subset<T>() { Parent = _nodeSet[j] };
            }

            List<GraphEdge<T>> result = new List<GraphEdge<T>>();
            foreach(var edge in edges)
            {
                GraphNode<T> from = GetRoot(subsets, edge.GetSource());
                GraphNode<T> to = GetRoot(subsets, edge.GetDestination());
                Console.WriteLine("Edge: " + edge.GetDestination()._identifier + " " + edge.GetSource()._identifier + " From: " + from._identifier + " To: " + to._identifier);

                if(from != to)
                {
                    result.Add(edge);
                    Union(subsets, from, to);
                }
            }
           
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<GraphNode<T>> PrimsAlgorithm()
        {
            Dictionary<GraphNode<T>, bool> msSet = new Dictionary<GraphNode<T>, bool>();
            Dictionary<GraphNode<T>, int> Keys = new Dictionary<GraphNode<T>, int>();
            List<GraphNode<T>> result = new List<GraphNode<T>>();

            foreach(var node in _nodeSet)
            {
                msSet.Add(node, false);
                Keys.Add(node, int.MaxValue);
            }

            Keys[_nodeSet.First()] = 0;
            result.Add(new GraphNode<T>(null));

            for(var i = 0; i < _nodeSet.Count - 1; i++)
            {
                // GraphNode<T> u = MinKey(Keys, msSet); 
                // msSet[u] = true;

                // foreach(var item in _nodeSet)
                // {
                //     if (msSet[item] == false && graph[u, v] < Keys[item]) 
                //     {
                //         result.Add(u);
                //         Keys[item] = graph[u, v];
                //     }
                // }

            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="mstSet"></param>
        /// <returns></returns>
        public GraphNode<T> MinKey(Dictionary<GraphNode<T>, int> Key, Dictionary<GraphNode<T>, bool> msSet)
        {

            return null;
        }
    }
}