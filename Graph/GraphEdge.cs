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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newSource"></param>
        public void SetSource(GraphNode<T> newSource)
        {
            _source = newSource;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newDestination"></param>
        public void SetDestination(GraphNode<T> newDestination)
        {
            _destination = newDestination;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GraphNode<T> GetSource()
        {
           return _source;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GraphNode<T> GetDestination()
        {
            return _destination;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetWeight()
        {
            return _weight;
        }
    }
}