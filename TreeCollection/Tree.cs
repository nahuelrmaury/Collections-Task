using System.Collections;

namespace TreeCollection
{
    public class Tree<T> : IEnumerable<T> 
    {
        private Node<T> _root = new Node<T>();
        private AddValueToNode<T> _addValue = new AddValueToNode<T>();
        private bool _isReversedReading;

        public Tree() 
        {
        }

        public void Add(T newElement)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}