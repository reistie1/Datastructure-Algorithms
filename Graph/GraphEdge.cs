using DatastructureAlgorithms.GraphNodes;

namespace DatastructureAlgorithms.GraphEdges
{
    public class GraphEdge<T> where T : class
    {
        private GraphNode<T> _source;
        private GraphNode<T> _destination;
        private int _weight;

        public GraphEdge(GraphNode<T> source, GraphNode<T> destination)
        {
            _source = source;
            _destination = destination;
        }

        public GraphEdge(GraphNode<T> source, GraphNode<T> destination, int weight)
        {
            _source = source;
            _destination = destination;
            _weight = weight;
        }

        public void SetSource(GraphNode<T> newSource)
        {
            _source = newSource;
        }
        public void SetDestination(GraphNode<T> newDestination)
        {
            _destination = newDestination;
        }

        public GraphNode<T> GetSource()
        {
           return _source;
        }
        public GraphNode<T> GetDestination()
        {
            return _destination;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public int GetWeight()
        {
            return _weight;
        }
    }
}