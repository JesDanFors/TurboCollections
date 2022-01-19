using System;
using System.Collections;
using System.Collections.Generic;


namespace TurboCollections{
    public class TurboList<T> : IEnumerable<T>{
        T[] items = Array.Empty<T>();
        public int Count{ get; private set; }
        public void Add(T item){
            EnsureSize(Count + 1);
            items[Count++] = item;
        }

        void EnsureSize(int size){
            if (items.Length >= size){
                return;
            }
            int newSize = Math.Max(size, items.Length * 2);

            T[] newArray = new T[newSize];
            for (int i = 0; i < Count; i++){
                newArray[i] = items[i];
            }
            items = newArray;
        }

        // gets the item at the specified index. If the index is outside the correct items, an exception is thrown.
        public T Get(int index){
            if (index < items.Length){
                return items[index];
            }
            else{
                throw new Exception("This index is out of bounds!");
            }
        }

        public void Set(int index, T item){
            items[index] = item;
        }

        // removes all items from the list.
        public void Clear(){
            for (int i = 0; i < Count; i++){
                items[i] = default;
            }
            Count = 0;
        }

        // removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
        public void RemoveAt(int index){
            for (int i = index; i < Count - 1; i++){
                items[i] = items[i + 1];
            }
            Count--;
        }
        
        // returns true, if the given item can be found in the list, else false.
        public bool Contains(T item){
            foreach (var VARIABLE in items){
                if (VARIABLE.Equals(item)){
                    return true;
                }
            }
            return false;
        }

        //returns the index of the given item if it is in the list, else -1
        public int IndexOf(T item){
            for (int i = 0; i < items.Length; i++){
                if (items[i].Equals(item)){
                    return i;
                }
            }
            return -1;
        }
        
        // removes the specified item from the list, if it can be found.
        public void Remove(T item){
            for (int i = 0; i < Count; i++){
                if (item.Equals(items[i])){
                    RemoveAt(i);
                }
            }
        }

        public void AddRange(IEnumerable<T> items){
            foreach (var item in items){
                Add(item);
            }
        }
        public Enumerator GetEnumerator()
        {
            return new Enumerator(items, Count);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public struct Enumerator : IEnumerator<T>
        {
            private readonly T[] _items;
            private readonly int _count;
            private int _index;

            public Enumerator(T[] items, int count){
                _items = items;
                _count = count;
                _index = -1;
            }
            
            public bool MoveNext(){
                if (_index >= _count)
                    return false; // exception
                return ++_index < _count;
            }

            public void Reset(){
                _index = -1;
            }
            public T Current => _items[_index];

            object IEnumerator.Current => Current;

            public void Dispose(){
                Reset();
            }
        }
    }
}

