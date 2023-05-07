using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCollection
{
    public class EnumerableList<T> : IEnumerable<T>
    {
        private ListEnumerator<T> _enumerator;

        public EnumerableList(IEnumerable<T> source)
        {
            _enumerator = new ListEnumerator<T>(source);
        }

        public IEnumerator GetEnumerator()
        {
            _enumerator.Reset();
            return _enumerator;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            _enumerator.Reset();
            return _enumerator;
        }
    }
}
