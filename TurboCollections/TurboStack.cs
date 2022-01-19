using System;

namespace TurboCollections{
    public class TurboStack<T>{
        T[] stack = Array.Empty<T>();
        
        public int Count{ get; private set; }

        public void Push(T item){
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++){
                newArray[i] = stack[i];
            }
            newArray[Count] = item;
            stack = newArray;
            Count++;
            
        }

        public T Peek(){
            return stack[^1];
        }

        public T Yeet(){
            T[] newArray = new T[Count - 1];
            var yeetie = Peek();
            for (int i = 0; i < newArray.Length; i++){
                newArray[i] = stack[i];
            }
            stack = newArray;
            return yeetie;
        }

        public void Clear(){
            stack = Array.Empty<T>();
        }
    }
}