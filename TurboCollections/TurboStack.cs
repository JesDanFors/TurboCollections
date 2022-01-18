using System;

namespace TurboCollections{
    public class TurboStack<T>{
        T[] stack = Array.Empty<T>();
        
        public int Count => stack.Length;

        public void Push(T item){
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++){
                newArray[i] = stack[i];
            }
            newArray[Count] = item;
            stack = newArray;
        }

        public T Peek(){
            return stack[^1];
        }
    }
}