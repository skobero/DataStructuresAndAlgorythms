namespace DataStructures.Helpers
{
    internal class NodeLinkedList<T>
    {
        public T Value;
        public NodeLinkedList<T>? Next { get; set; }
        public NodeLinkedList<T>? Prev { get; set; }
    }
}
