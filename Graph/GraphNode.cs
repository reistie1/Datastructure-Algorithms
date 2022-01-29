using System.Collections.Generic;
using DatastructureAlgorithms.GraphEdges;

namespace DatastructureAlgorithms.GraphNodes
{
    public class GraphNode
    {
        public string _identifier;
        public List<GraphEdge> neighbors;
        public GraphNode(string identifier)
        {
            _identifier = identifier;
        }

        public void UpdateIdentifier(string newIdentifier)
        {
            _identifier = newIdentifier;
        }
    }
}