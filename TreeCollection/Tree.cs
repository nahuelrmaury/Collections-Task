using System.Collections;

namespace TreeCollection
{
    public class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T> _root = new Node<T>();
        private AddValueToNode<T> _addValueToNode = new AddValueToNode<T>();
        private bool _isReversedReading;

        public Tree() 
        {
        }

        public Tree(bool isReversedReading)
        {
            _isReversedReading = isReversedReading;
        }

        public void Add(T newElement)
        {
            if (!IsDefault(newElement))
                AddNode(_root, newElement);
        }

        private static bool IsDefault(T t) { return EqualityComparer<T>.Default.Equals(t, default); }

        private void AddNode(Node<T> root, T newElement)
        {
            bool isNewElementNull = IsDefault(root._newElement);

            if (isNewElementNull)
            {
                root.SetNewElement(newElement);
                _addValueToNode.counter++;
            }
            else if (newElement.CompareTo(root.GetNewElement()) == 0)
            {
                throw new ArgumentException("Values are equal");
            }
            else if (newElement.CompareTo(root.GetNewElement()) > 0)
            {
                if (root.Right == null)
                    root.Right = new Node<T>();

                AddNode(root.Right, newElement);
            }
            else if (newElement.CompareTo(root.GetNewElement()) < 0)
            {
                if (root.Left == null)
                    root.Left = new Node<T>();

                AddNode(root.Left, newElement);
            }
        }

        public int getNodeCounter()
        {
            return _addValueToNode.counter;
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