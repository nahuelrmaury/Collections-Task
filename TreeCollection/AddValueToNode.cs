using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCollection
{
    public class AddValueToNode<T>
    {
        public int counter { get; set; } = 0;
        private T[] _value;
        private int pointer = 0;

        public void AddValue(T value)
        {
            _value[pointer++] = value;
        }

        public void SetSize()
        {
            _value = new T[counter];
            pointer = 0;
        }

        public T[] GetValue()
        {
            return this._value;
        }
    }
}
