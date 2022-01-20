namespace TurboCollections;

public class TurboQueue<T>{
    T[] Queue = Array.Empty<T>();
    
    public int Count{ get; private set; }

    int startOfQueue;

    void EnsureSize(int size){
        if (Queue.Length >= size){
            return;
        }
        int newSize = Math.Max(size, Queue.Length * 2);
        T[] newArray = new T[newSize];
        for (int i = 0; i < Count; i++){
            newArray[i] = Queue[i];
        }
        Queue = newArray;
    }
    public void Enqueue(T item){
        EnsureSize(Count+1);
        if ((Count+startOfQueue) >= Queue.Length){
            Queue[(Count + startOfQueue) % Queue.Length] = item;
        }
        else{
            Queue[((Count + startOfQueue) % Queue.Length)] = item;
        }
        
        foreach (var VARIABLE in Queue){
            Console.WriteLine(VARIABLE);
        }
        ++Count;
    }

    public T Peak(){
        return Queue[startOfQueue];
    }

    public T Dequeue(){
        var item = Peak();
        startOfQueue++;
        startOfQueue %= Queue.Length;
        Count--;
        return item;
    }

    public void Clear(){
        Queue = new T[4];
        Count = 0;
    }
}