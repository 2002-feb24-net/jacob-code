using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // behaves like a List<T> but keep itself sorted

    // you declase a class's type parameter with <(name)> right after the class name
    //the name can be any type
    //after the where come type constraints
    // e.g. class, struct, any specific type
    class SortedSequence<T> : IEnumerable<T> where T : class
    {
        List<T> _list = new List<T>();
        
        //lets say for no reason
        //this class always starts out with one element in it
        //which will be the default value of that type.
        public SortedSequence()
        {
            Add(default);
        }
        public void Add(T item)
        {
            _list.Add(item);
            _list.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
        }


        // implement indexer operator
        public T this[int i]
        {
            get => _list[i];
            set => _list[i] = value;
            // (using expression body syntax so its easier to write)
        }
    }
}
