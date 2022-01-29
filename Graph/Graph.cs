using System.Linq;
using System.Collections.Generic;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;
using System;

namespace DatastructureAlgorithms.Graphs
{
    public class Graph
    {
        public List<GraphEdge> _edgeList;
        public Dictionary<string,GraphNode> _nodeSet;
        public Graph()
        {
            _edgeList = new List<GraphEdge>();
            _nodeSet = new Dictionary<string,GraphNode>();
        }

        public void AddNode(GraphNode newNode)
        {
            _nodeSet.Add(newNode._identifier, newNode);
        }
        public void AddEdge(GraphEdge newEdge)
        {
            _edgeList.Add(newEdge);
        }

        public override string ToString()
        {
            string result = "";
            foreach(var item in _edgeList)
            {
                result += item._weight + "->";
            }

            return result;
        }
    }
}