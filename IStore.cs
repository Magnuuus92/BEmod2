namespace IStore
{
    public interface IStore<T>
    {
        //Legge til, velge og telle ADD,GET,COUNT
        void Add(T item);
        T Get(int index);
        int Count { get; }
        // Fjerne ved bruk av navn, bruk av index posisjon og fjerne alt RMV,RMVAT,CLR
        bool Remove(T item);
        void RemoveAt(int index);
        void Clear();
    }


}