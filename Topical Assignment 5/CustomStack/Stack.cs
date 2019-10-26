using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace CustomStack
{
    public class Stack<T>:LinkedList<T>
    {
        // note: the Count method is implemented in the LinkedList class and must not be replicated here

        // ProfReynolds 1st submission
        // Stack inherits LinkedList. Therefore, the collection internal to LinkedList is
        // fully available here. You do NOT have to declare your own collection.
        // the parent LinkedList provides these important properties and methods:
        // CountdownEvent, FirstChanceExceptionEventArgs, Last, AddFirst, AddLast, ...
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=netframework-4.8
        private LinkedList<T> _list =
            new LinkedList<T>();

        /// <summary>
        /// Adds the specified item to the stack
        /// </summary>
        /// <param name="newValue"></param>
        public void Push(T newValue)
        {
            // ProfReynolds 1st submission
            // so, continuing the thread above, you do not need to reference the collection,
            // just say this: AddFirst(newValue)
            _list.AddFirst(newValue);
        }

        /// <summary>
        /// Removes and returns the top item for the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Pop()
        {
            // ProfReynolds 1st submission
            // ditto
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

            // ProfReynolds 1st submission
            // ditto
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return _list.First.Value;
        }

    }
}
