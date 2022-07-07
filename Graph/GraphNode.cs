using System.Collections.Generic;
using System.Linq;
using DatastructureAlgorithms.GraphEdges;

namespace DatastructureAlgorithms.GraphNodes
{
    public class GraphNode<T> where T : class
    {
        public T _identifier;
        public bool _isVisited;
        public int _weight;
        public int Index;
        public List<GraphNode<T>> connections;
        public GraphNode(T identifier)
        {
            _identifier = identifier;
            _isVisited = false;
            connections = new List<GraphNode<T>>();
            _weight = 0;
        }

        public GraphNode(T identifier, int weight)
        {
            _identifier = identifier;
            _isVisited = false;
            connections = new List<GraphNode<T>>();
            _weight = weight;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newIdentifier"></param>
        public void SetIdentifier(T newIdentifier)
        {
            _identifier = newIdentifier;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SetVisitState"></param>
        public void SetVisited(bool SetVisitState)
        {
            _isVisited = SetVisitState;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public void AddConnection(GraphNode<T> connection)
        {
            connections.Add(connection);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<GraphNode<T>> GetNodeConnections()
        {
            return connections;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T GetIdentifier()
        {
            return this._identifier;
        }

        public bool getVisitStatus()
        {
            return _isVisited;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public bool RemoveConnection(T identifier)
        {
            var result = connections.Where(c => c.GetIdentifier() == identifier).FirstOrDefault();

            if(result != null)
            {
                connections.Remove(result);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GraphNode<T> GetCurrentNode()
        {
            return this;
        }
    }
}