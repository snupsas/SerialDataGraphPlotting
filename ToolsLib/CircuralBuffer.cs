using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLib
{
    public class CircuralBuffer<T> : IEnumerable<T>
    {
        private readonly int CAPACITY = 200;
        private Queue<T> _buffer = new Queue<T>();
        public event EventHandler AddedNewItem;

        public void Add(T item)
        {
            if (_buffer.Count == CAPACITY)
            {
                _buffer.Dequeue();
                //_buffer.RemoveAt(CAPACITY - 1);
            }
            _buffer.Enqueue(item);
            FireAddedEvent();
        }

        private void FireAddedEvent()
        {
            if (AddedNewItem != null)
            {
                AddedNewItem.Invoke(this, null);   
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _buffer.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
