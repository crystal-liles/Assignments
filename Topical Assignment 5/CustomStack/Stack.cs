using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace CustomStack
{
    public class Stack<T>:LinkedList<T>
    {
        // note: the Count method is implemented in the LinkedList class and must not be replicated here

        private LinkedList<T> _list =
            new LinkedList<T>();

        /// <summary>
        /// Adds the specified item to the stack
        /// </summary>
        /// <param name="newValue"></param>
        public void Push(T newValue)
        {
            _list.AddFirst(newValue);
        }

        /// <summary>
        /// Removes and returns the top item for the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }

        /// <summary>
        /// Returns the top item from the stack without removing it from the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Peek()
        {

            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return _list.First.Value;
        }

    }
}
