using System;
using System.Collections.Generic;

class MinhaPilha<T>
{
    private List<T> elementos = new List<T>();

    public void Push(T item)
    {
        elementos.Add(item); 
    }

    public T Pop()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("A pilha está vazia!");

        T item = elementos[elementos.Count - 1]; 
        elementos.RemoveAt(elementos.Count - 1); 
        return item;
    }

    public T Peek()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("A pilha está vazia!");

        return elementos[elementos.Count - 1]; 
    }

    public int Count()
    {
        return elementos.Count; 
    }
}