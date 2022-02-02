using System.Linq;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;
using System;
using DatastructureAlgorithms.Linked_List;
using System.Collections.Generic;
using Datastructures_LinkedList;

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
            LinkedLists stack = new LinkedLists();
            GraphNode firstNode = _nodeSet.FirstOrDefault().Value;

            stack.AddToStart(firstNode._identifier);
            var j = 5;

            while(j-- > 0)
            {
                var node = stack.RemoveFromStart();
                var visitedNode = _nodeSet.Where(n => n.Value._identifier == node.otherValue).FirstOrDefault().Value;

                visitedNode.UpdateVisited(true);
                var nodeEdgeList = _edgeList.Where(l => l.GetSource()._identifier == node.otherValue).ToArray();

                for(var i = 0; i < nodeEdgeList.Length; i++)
                {
                    Console.WriteLine($"Destination: {nodeEdgeList[i].GetDestination()._identifier}, Visited: {nodeEdgeList[i].GetDestination()._isVisited}");
                    stack.AddToStart(nodeEdgeList[i].GetDestination()._identifier);
                }

            }

        }

        public void BreadthFirstSearch()
        {
            LinkedLists queue = new LinkedLists();
            GraphNode firstNode = _nodeSet.FirstOrDefault().Value;

            //add firstnode to end of queue and mark node as visited
            queue.AddToEnd(firstNode._identifier);
            firstNode._isVisited = true;

            while(queue.size != 0)
            {
                ListNode node = queue.RemoveFromStart();
                Console.WriteLine($"node value: {node.otherValue}");
                var nodeEdgeList = _edgeList.Where(l => l.GetSource()._identifier == node.otherValue).ToArray();
                

                for(var i = 0; i < nodeEdgeList.Length; i++)
                {
                    Console.WriteLine($"Destination: {nodeEdgeList[i].GetDestination()._identifier}, Visited: {nodeEdgeList[i].GetDestination()._isVisited}");
                    if(this.FindAdjacentNode(nodeEdgeList, i))
                    {
                        nodeEdgeList[i].GetDestination().UpdateVisited(true);
                        queue.AddToEnd(nodeEdgeList[i].GetDestination()._identifier);
                    }
                }
            }
        }

        private bool FindAdjacentNode(GraphEdge[] nodeEdgeList, int index)
        {
            if(!nodeEdgeList[index].GetDestination()._isVisited)
            {
                return true;
            }

            return false;
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