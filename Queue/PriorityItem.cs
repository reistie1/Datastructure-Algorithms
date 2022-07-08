namespace DatastructureAlgorithms.PriorityItem
{
    public class PriorityItem<T> where T : class
    {
        public T Value;
        public int Priority;
        public PriorityItem(T value, int priority)
        {
            this.Value = value;
            this.Priority = priority;
        }
    }
}