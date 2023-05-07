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
                throw new Exception();
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

        private void NormalOrder(Node<T> root)
        {
            if (root.Left != null)
                NormalOrder(root.Left);

            _addValueToNode.AddValue(root.GetNewElement());

            if (root.Right != null)
                NormalOrder(root.Right);
        }

        private void ReverseOrder(Node<T> root)
        {
            if (root.Right != null)
                ReverseOrder(root.Right);

            _addValueToNode.AddValue(root.GetNewElement());

            if (root.Left != null)
                ReverseOrder(root.Left);
        }

        public EnumerableList<T> Traverse()
        {
            _addValueToNode.SetSize();

            if (_isReversedReading)
                ReverseOrder(_root);
            else
                NormalOrder(_root);

            EnumerableList<T> values = new EnumerableList<T>(_addValueToNode.GetValue());
            return values;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Traverse()).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Traverse().GetEnumerator();
        }
    }
}