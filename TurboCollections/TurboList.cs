using System;


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
        
        // gets the item at the specified index. If the index is outside the correct range, an exception is thrown.
        public T Get(int index){
            if (index < items.Length){
                return items[index];
            }
            else{
                throw new Exception("This index is out of bounds!");
            }
        }
    }
}

