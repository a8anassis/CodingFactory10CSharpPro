namespace FileManagementApp;

internal class DLList<T>
{
    private readonly LinkedList<ListNode<T>> _list = new();

    public bool IsEmpty => _list.Count == 0;

    private ListNode<T>? FindNode(T t)
    {
        foreach (var node in _list)
        {
            if (EqualityComparer<T>.Default.Equals(node.Value, t))
            {
                return node;
            }
        }
        return null;
    }


    private void InsertLast(T t) => _list.AddLast(new ListNode<T> { Value = t, Count = 1 });


    public void UpSert(T t)
    {
        var node = FindNode(t);
        if (node is null) InsertLast(t);
        else node.Count++;
    }

    public void SortByCount() => Reorder(_list.OrderByDescending(n => n.Count).ToList());
    public void SortByValue() => Reorder(_list.OrderBy(n => n.Value).ToList());

    private void Reorder(List<ListNode<T>> sorted)
    {
        _list.Clear();
        foreach (var node in sorted)
        {
            _list.AddLast(node);
        }
    }

    private int TotalCount() => _list.Sum(n => n.Count);

    public void PrintList()
    {
        if (IsEmpty)
        {
            throw new ListIsEmptyException();
        }

        int total = TotalCount();
        foreach (var node in _list)
        {
            double frequency = (double)node.Count / total;
            Console.WriteLine($"Value: {node.Value}: Frequency: {frequency:P2} ");
        }
    }
}
