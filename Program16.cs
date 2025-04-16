class MeuDeque<T>
{
    private List<T> lista = new List<T>();

    public void AddFirst(T item) => lista.Insert(0, item);
    public void AddLast(T item) => lista.Add(item);
    public void RemoveFirst()
    {
        if (lista.Count > 0)
            lista.RemoveAt(0);
        else
            Console.WriteLine("Deque vazio!");
    }
    public void RemoveLast()
    {
        if (lista.Count > 0)
            lista.RemoveAt(lista.Count - 1);
        else
            Console.WriteLine("Deque vazio!");
    }
    public void Print() => Console.WriteLine(string.Join(", ", lista));

    public static void Main()
    {
        var deque = new MeuDeque<int>();
        deque.AddFirst(1);
        deque.AddLast(2);
        deque.AddFirst(0);
        deque.RemoveLast();
        deque.Print();
    }
}