class LRUCache<T>
{
    private int capacidade;
    private Queue<T> fila = new Queue<T>();
    private HashSet<T> set = new HashSet<T>();

    public LRUCache(int capacidade)
    {
        this.capacidade = capacidade;
    }

    public void Acessar(T item)
    {
        if (set.Contains(item))
        {
            Queue<T> novaFila = new Queue<T>();
            foreach (var i in fila)
            {
                if (!EqualityComparer<T>.Default.Equals(i, item))
                    novaFila.Enqueue(i);
            }
            fila = novaFila;
            set.Remove(item);
        }
        else if (fila.Count >= capacidade)
        {
            var removido = fila.Dequeue();
            set.Remove(removido);
        }

        fila.Enqueue(item);
        set.Add(item);
        Console.WriteLine("Cache: " + string.Join(", ", fila));
    }

    public static void Main()
    {
        var cache = new LRUCache<string>(3);
        cache.Acessar("A");
        cache.Acessar("B");
        cache.Acessar("C");
        cache.Acessar("A");
        cache.Acessar("D");
    }
}
