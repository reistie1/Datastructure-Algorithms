using System.Linq;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;
using System;
using DatastructureAlgorithms.Linked_List;
using System.Collections.Generic;
using Datastructures_LinkedList;
using DatastructureAlgorithms.Queue;

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
            _nodeSet.Add(newNode.GetIdentifier(), newNode);

            return newNode;
        }
        public void AddEdge(GraphNode sourceNode, GraphNode destinationNode)
        {
            _nodeSet[destinationNode.GetIdentifier()].AddConnection(sourceNode);
            _nodeSet[sourceNode.GetIdentifier()].AddConnection(destinationNode);
        }

        public void DepthFirstSearch()
        {
            LinkedLists<string> stack = new LinkedLists<string>();
            var currentNode = _nodeSet.FirstOrDefault().Value;

            stack.InsertAtStart(currentNode._identifier);
            currentNode.SetVisited(true); 

            do
            {
                stack.printList();
                if(!currentNode.connections.Any(c => c.getVisitStatus() == false))
                {
                    stack.RemoveFromStart();
                    currentNode = _nodeSet[stack.Peek().value]; 
                }
                else
                {
                    currentNode = currentNode.connections.Where(c => c._isVisited == false)?.FirstOrDefault().GetCurrentNode();

                    currentNode.SetVisited(true);
                    stack.InsertAtStart(currentNode._identifier);
                }
            }while(stack.GetSize() > 0);
        } 

        public void BreadthFirstSearch()
        {
            Queues<string> queue = new Queues<string>();
            GraphNode firstNode = _nodeSet.FirstOrDefault().Value;

            //add firstnode to end of queue and mark node as visited
            queue.Enqueue("start");
            firstNode.SetVisited(true);

            while(!queue.isEmpty())
            {
                queue.ToList();

                if(!firstNode.connections.Any(c => c.getVisitStatus() == false))
                {
                    queue.Dequeue();
                    firstNode = _nodeSet[queue.Peek().value];
                }
                else
                {
                    var nodeList = firstNode.connections.Where(c => c._isVisited == false).ToList();

                    if(nodeList.Count > 0)
                    {
                        var i = nodeList.Count - 1;

                        do
                        {
                            firstNode = _nodeSet[nodeList[i].GetIdentifier()];
                            nodeList[i].SetVisited(true);
                            queue.Enqueue(nodeList[i].GetIdentifier());
                        }while(i-- > 0);
                    }

                    queue.Dequeue();
                    firstNode = _nodeSet[queue.Peek().value];
                    // else
                    // {
                    //     queue.Dequeue();
                    //     firstNode = _nodeSet[queue.Peek().value];
                    // }
                }
            }
        }

        private bool FindAdjacentNode(GraphEdge[] nodeEdgeList, int index)
        {
            if(!nodeEdgeList[index].GetDestination().getVisitStatus())
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