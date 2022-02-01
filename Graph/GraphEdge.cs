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

        public GraphNode GetSource()
        {
           return _source;
        }
        public GraphNode GetDestination()
        {
            return _destination;
        }
        public int GetWeight()
        {
           return _weight;
        }
    }
}