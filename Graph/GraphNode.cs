using System.Collections.Generic;
using System.Linq;
using DatastructureAlgorithms.GraphEdges;

namespace DatastructureAlgorithms.GraphNodes
{
    public class GraphNode<T> where T : class
    {
        public T _identifier;
        public bool _isVisited;
        public int Index;
        public List<GraphNode<T>> connections;
        public GraphNode(T identifier)
        {
            _identifier = identifier;
            _isVisited = false;
            connections = new List<GraphNode<T>>();
        }

        public void SetIdentifier(T newIdentifier)
        {
            _identifier = newIdentifier;
        }

        public void SetVisited(bool SetVisitState)
        {
            _isVisited = SetVisitState;
        }

        public void AddConnection(GraphNode<T> connection)
        {
            connections.Add(connection);
        }

        public List<GraphNode<T>> GetNodeConnections()
        {
            return connections;
        }

        public T GetIdentifier()
        {
            return this._identifier;
        }

        public bool getVisitStatus()
        {
            return _isVisited;
        }

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

        public GraphNode<T> GetCurrentNode()
        {
            return this;
        }
    }
}