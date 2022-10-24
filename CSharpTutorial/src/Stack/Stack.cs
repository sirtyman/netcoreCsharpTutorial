using System;
using System.Collections;


namespace Lifo
{
    public class Stack
    {
        private ArrayList _stack = new ArrayList();

        public void Push(object? obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null object cannot be added onto the stack!");
            }
            _stack.Add(obj);
        }

        public object? Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is already empty!");
            }

            var lastElementIndex = _stack.Count - 1;
            object? returnObjRef = _stack[lastElementIndex];
            _stack.RemoveAt(lastElementIndex);
            return returnObjRef;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}