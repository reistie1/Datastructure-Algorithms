using System.Collections.Generic;
using DatastructureAlgorithms.GraphEdges;

namespace DatastructureAlgorithms.GraphNodes
{
    public class GraphNode
    {
        public string _identifier;
        public bool _isVisited;
        public List<GraphEdge> neighbors;
        public GraphNode(string identifier)
        {
            _identifier = identifier;
            _isVisited = false;
        }

        public void UpdateIdentifier(string newIdentifier)
        {
            _identifier = newIdentifier;
        }

        public void UpdateVisited(bool SetVisitState)
        {
            _isVisited = SetVisitState;
        }
    }
}