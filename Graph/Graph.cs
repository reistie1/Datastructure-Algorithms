using System.Linq;
using DatastructureAlgorithms.GraphEdges;
using DatastructureAlgorithms.GraphNodes;
using System.Collections.Generic;
using DatastructureAlgorithms.Queue;
using DatastructureAlgorithms.Stack;

namespace DatastructureAlgorithms.Graphs
{
    public class Graph<T> where T : class
    {
        public List<GraphEdge<T>> _edgeList;
        public Dictionary<T,GraphNode<T>> _nodeSet;
        public Graph()
        {
            _edgeList = new List<GraphEdge<T>>();
            _nodeSet = new Dictionary<T,GraphNode<T>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newNode"></param>
        /// <returns></returns>
        public GraphNode<T> AddNode(GraphNode<T> newNode)
        {
            _nodeSet.Add(newNode.GetIdentifier(), newNode);

            return newNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceNode"></param>
        /// <param name="destinationNode"></param>
        public void AddEdge(GraphNode<T> sourceNode, GraphNode<T> destinationNode)
        {
            _nodeSet[destinationNode.GetIdentifier()].AddConnection(sourceNode);
            _nodeSet[sourceNode.GetIdentifier()].AddConnection(destinationNode);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DepthFirstSearch()
        {
            Stacks<T> stack = new Stacks<T>();
            var currentNode = _nodeSet.FirstOrDefault().Value;

            stack.Push(currentNode._identifier);
            currentNode.SetVisited(true); 

            do
            {
                stack.ToList();
                if(!currentNode.connections.Any(c => c.getVisitStatus() == false))
                {
                    stack.Pop();
                    currentNode = _nodeSet[stack.Peek().value]; 
                }
                else
                {
                    currentNode = currentNode.connections.Where(c => c._isVisited == false)?.FirstOrDefault().GetCurrentNode();

                    currentNode.SetVisited(true);
                    stack.Push(currentNode._identifier);
                }
            }while(!stack.isEmpty());
        } 

        /// <summary>
        /// 
        /// </summary>
        public void BreadthFirstSearch()
        {
            Queues<T> queue = new Queues<T>();
            GraphNode<T> firstNode = _nodeSet.FirstOrDefault().Value;
            T temp = null;

            //add firstnode to end of queue and mark node as visited
            queue.Enqueue(temp);
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
                }
            }
        }

        // public override string ToString()
        // {
        //     string result = "";
        //     foreach(var item in _edgeList)
        //     {
        //         result += item._weight + "->";
        //     }

        //     return result;
        // }
    }
}