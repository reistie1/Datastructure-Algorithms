using DatastructureAlgorithms.GraphNodes;

namespace DatastructureAlgorithms.GraphEdges
{
    public class GraphEdge
    {
        private GraphNode _source;
        private GraphNode _destination;
        public int _weight;

        public GraphEdge(GraphNode source, GraphNode destination, int weight)
        {
            _source = source;
            _destination = destination;
            _weight = weight;
        }

        public void UpdateSource(GraphNode newSource)
        {
            _source = newSource;
        }
        public void UpdateDestination(GraphNode newDestination)
        {
            _destination = newDestination;
        }
        public void UpdateWeight(int newWeight)
        {
            _weight = newWeight;
        }
    }
}