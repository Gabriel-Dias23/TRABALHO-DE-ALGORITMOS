using System;
using System.Collections.Generic;


class MinhaFila<T>
{
    private List<T> elementos = new List<T>(); 

    
    public void Enqueue(T item)
    {
        elementos.Add(item);
    }

    
    public T Dequeue()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("A fila está vazia!");

        T item = elementos[0]; 
        elementos.RemoveAt(0); 
        return item;
    }

  
    public T Peek()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("A fila está vazia!");

        return elementos[0];
    }

    public int Count()
    {
        return elementos.Count;
    }
}