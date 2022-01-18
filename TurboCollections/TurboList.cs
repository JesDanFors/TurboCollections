using System;
using System.Collections.Generic;


namespace TurboCollections{
    public class TurboList<T>{
        
        int size;
        T[] items = Array.Empty<T>();

        public int Count => items.Length;
        
        // adds one item to the end of the list.
        public void Add(T item){
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++){
                newArray[i] = items[i];
            }
            newArray[Count] = item;
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

        // removes all items from the list.
        public void Clear(){
            items = Array.Empty<T>();
        }

        // removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
        public void RemoveAt(int index){
            T[] newArray = new T[Count - 1];
            for (int i = 0; i < Count-1; i++){
                if (i >= index){
                    newArray[i] = items[i+1];
                }
                else{
                    newArray[i] = items[i];
                }
            }
            items = newArray;
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
            foreach (var VARIABLE in items){
                var temp = items.GetEnumerator();
                Add(temp.Current);
            }
        }
    }
}

