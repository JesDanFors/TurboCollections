namespace TurboCollections;

public class TurboHashSet<T>{
    T[] hashSet = Array.Empty<T>();
    int items = 0;
    public bool Insert(T item){
        items++;
        if (hashSet.Length < MathF.Round(1.3f * items)){
            Resize();
        }
        return true;
    }

    public bool Exists(T item){
        return true;
    }

    public bool Remove(T item){
        return true;
    }

    void Resize(){
        var tempArray = new TurboHashSet<T>[GetNextPrime(hashSet.Length)];
        for (int i = 0; i < hashSet.Length; i++){
            tempArray[i].Insert(hashSet[i]);
        }
    }

    int GetNextPrime(int prevPrime){
        while(true){
            bool isPrime = true;
            prevPrime = prevPrime + 1;
            int squaredNumber = (int)Math.Sqrt(prevPrime);
            for (int i = 2; i <= squaredNumber; i++){
                if (prevPrime % i == 0){
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
                return prevPrime;
        }
    }
}