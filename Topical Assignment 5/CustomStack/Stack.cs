using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace CustomStack
{
    public class Stack<T> : IEnumerable<T>
    {
        // note: the Count method is implemented in the LinkedList class and must not be replicated here

        private LinkedList<T> _list =
            new LinkedList<T>();

        T[] _items = new T[0];

        int _size;


    /// <summary>
        /// Adds the specified item to the stack
        /// </summary>
        /// <param name="newValue"></param>
        public void Push(T newValue)
        {
            //_size = 0 ... first push
            //_size == length ... growth boundary
            if (_size == _items.Length)
            {
                int newLength = _size == 0 ? 4 : _size * 2;

                T[] newArray = new T[newLength];
                _items.CopyTo(newArray, 0);
                _items = newArray;
            }

            _items[_size] = newValue;
            _size++;
        }

    /// <summary>
        /// Removes and returns the top item for the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            _size--;

            return _items[_size];
        }

        /// <summary>
        /// Returns the top item from the stack without removing it from the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Peek()
        {

            if (_size == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return _items[_size - 1];
        }

        public int Count => _size;

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _size - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
