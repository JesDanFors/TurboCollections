namespace TurboCollections;

public class TurboQueue<T>{
    T[] Queue = Array.Empty<T>();
    
    public int Count{ get; private set; }

    public void Enqueue(T item){
        T[] newArray = new T[Count + 1];
        newArray[0] = item;
        for (int i = 1; i < Count+1; i++){
            newArray[i] = Queue[i - 1];
        }
        Queue = newArray;
        Count++;
    }

    public T Peak(){
        return Queue[^1];
    }

    public T Dequeue(){
        T[] newArray = new T[Count - 1];
        var top = Queue[^1];
        for (int i = 0; i < Count-1; i++){
            newArray[i] = Queue[i];
        }
        Queue = newArray;
        Count--;
        return top;
    }
}