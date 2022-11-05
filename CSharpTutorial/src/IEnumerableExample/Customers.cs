using System;
using System.Collections;
using System.Collections.Generic;


namespace IEnumerableExample
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] _collection;

        public MyList(T[] collection)
        {
            _collection = new T[collection.Length];
            for (int i = 0; i < collection.Length; i++ )
            {
                _collection[i] = collection[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (new MyListIterator<T>(_collection));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) (new MyListIterator<T>(_collection));
        }
    }


    public class MyListIterator<T> : IEnumerator<T>   
    {
        private int _currentIndex = -1;
        private T[] _customers;

        public MyListIterator(T[] customers)
        {
            _customers = customers;
        }

        T IEnumerator<T>.Current
        {
            get 
            {
                return _customers[_currentIndex];
            }
        }

        object? IEnumerator.Current
        {
            get 
            {
                return _customers[_currentIndex];
            }
        }

        bool IEnumerator.MoveNext()
        {
            bool? result = null;
            if (_currentIndex < _customers.Length - 1)
            {
                _currentIndex++;
                result = true;
            }
            else
                result = false;
            return (bool) result;
        }

        void IEnumerator.Reset()
        {
            _currentIndex = -1;
        }

        void IDisposable.Dispose()
        {

        }
    }
}