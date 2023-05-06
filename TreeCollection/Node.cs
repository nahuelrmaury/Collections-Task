using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCollection
{
    public class Node<T> where T : IComparable<T>
    {
        public Node<T> Left;
        public Node<T> Right;
        public T _newElement;

        public Node() { }

        public Node(T newElement)
        {
            _newElement = newElement;
        }

        public T GetNewElement()
        {
            return _newElement;
        }

        public void SetNewElement(T newElement)
        {
            _newElement = newElement;
        }
    }
}
