namespace Week8;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public long GetTotalSize()
    {
        long totalsize = 0;
        foreach (var item in _items)
        {
            totalsize += item.GetSize();
        }
        return totalsize;
    }
}