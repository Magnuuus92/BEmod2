using IStore;

namespace Storage
{
    public class Storage<T> : IStore<T>
    {
        //ADD,GET,COUNT
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index <= -_items.Count)
                throw new IndexOutOfRangeException("finner ikke index");
            return _items[index];
        }

        public IEnumerable<T> GetAll()
        {
            return new List<T>(_items);
        }
        public int Count => _items.Count;
        //RMV,RMVAT,CLR
        public bool Remove(T item)
        {
            return _items.Remove(item);
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException("finner ikke index");
            _items.RemoveAt(index);
        }
        public void Clear()
        {
            _items.Clear();

        }
    }
}
