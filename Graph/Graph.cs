using System.Linq;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;
using System;
using DatastructureAlgorithms.Linked_List;
using System.Collections.Generic;

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

        public GraphNode AddNode(GraphNode newNode)
        {
            _nodeSet.Add(newNode._identifier, newNode);

            return newNode;
        }
        public void AddEdge(GraphEdge newEdge)
        {
            _edgeList.Add(newEdge);
        }

        public void DepthFirstSearch()
        {
            LinkedLists<GraphNode> stack = new LinkedLists<GraphNode>();
        }

        public void BreadthFirstSearch()
        {
            LinkedLists<GraphNode> queue = new LinkedLists<GraphNode>();

            var firstNode = _nodeSet.FirstOrDefault().Value;
            queue.AddToEnd(firstNode);
            firstNode._isVisited = true;

            while(queue.size != 0)
            {
                var node = queue.RemoveFromStart();
                Console.WriteLine($"Value: {node.value._identifier}");
                var nodeEdgeList = _edgeList.Where(l => l.GetSource()._identifier == node.value._identifier).ToArray();

                for(var i = 0; i < nodeEdgeList.Length; i++)
                {
                    Console.WriteLine($"{nodeEdgeList[i].GetSource()._identifier} {nodeEdgeList[i].GetDestination()._identifier} {nodeEdgeList[i].GetWeight()}");
                    if(nodeEdgeList[i].GetDestination()._isVisited == false)
                    {
                        nodeEdgeList[i].GetDestination().UpdateVisited(true);
                        Console.WriteLine(nodeEdgeList[i].GetDestination()._identifier + "\n\n");
                        queue.AddToEnd(nodeEdgeList[i].GetDestination());
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        private void FindAdjacentNode()
        {

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