using System.Collections.Generic;
using System.Linq;
using DatastructureAlgorithms.GraphEdges;

namespace DatastructureAlgorithms.GraphNodes
{
    public class GraphNode
    {
        public string _identifier;
        public bool _isVisited;
        public List<GraphNode> connections;
        public GraphNode(string identifier)
        {
            _identifier = identifier;
            _isVisited = false;
            connections = new List<GraphNode>();
        }

        public void SetIdentifier(string newIdentifier)
        {
            _identifier = newIdentifier;
        }

        public void SetVisited(bool SetVisitState)
        {
            _isVisited = SetVisitState;
        }

        public void AddConnection(GraphNode connection)
        {
            connections.Add(connection);
        }

        public List<GraphNode> GetNodeConnections()
        {
            return connections;
        }

        public string GetIdentifier()
        {
            return this._identifier;
        }

        public bool getVisitStatus()
        {
            return _isVisited;
        }

        public bool RemoveConnection(string identifier)
        {
            var result = connections.Where(c => c.GetIdentifier() == identifier).FirstOrDefault();

            if(result != null)
            {
                connections.Remove(result);
                return true;
            }

            return false;
        }

        public GraphNode GetCurrentNode()
        {
            return this;
        }
    }
}