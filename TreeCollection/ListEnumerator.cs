using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCollection
{
    public class ListEnumerator<T> : IEnumerator<T>
    {
        private List<Element<T>> _source = new List<Element<T>>();
        private int position = -1;
        T IEnumerator<T>.Current => _current;
        private T _current;

        public class Element<T>
        {
            public T Value;
        }

        public ListEnumerator(IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                _source.Add(new Element<T> { Value = item });
            }
        }

        public object Current
        {
            get { return _source[position].Value; }
        }

        public bool MoveNext()
        {
            position++;
            return position < _source.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }
    }
}