namespace TurboCollections;

public class TurboQueue<T>{
    T[] Queue = Array.Empty<T>();
    
    public int Count{ get; private set; }

    public void Enqueue(T item){
        T[] newArray = new T[Count + 1];
        newArray[0] = item;
        for (int i = Count-1; i >= 1; i--){
            newArray[i] = Queue[i];
            Console.WriteLine(newArray[i]);
        }
        Queue = newArray;
        Count++;
    }

    public T Peak(){
        return Queue[^1];
    }
}