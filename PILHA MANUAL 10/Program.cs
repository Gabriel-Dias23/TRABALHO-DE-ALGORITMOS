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

class Program
{
    static void Main()
    {
        MinhaPilha<int> pilha = new MinhaPilha<int>();

        Console.WriteLine("Adicionando elementos 10, 20 e 30 na pilha...");
        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        Console.WriteLine("Topo da pilha (Peek): " + pilha.Peek()); 
        Console.WriteLine("Removendo topo da pilha (Pop): " + pilha.Pop()); 

        Console.WriteLine("Topo atual (Peek): " + pilha.Peek());
        Console.WriteLine("Quantidade atual de elementos: " + pilha.Count()); 

        Console.WriteLine("Removendo todos os elementos:");
        Console.WriteLine(pilha.Pop()); 
        Console.WriteLine(pilha.Pop()); 

        Console.WriteLine("Quantidade atual de elementos: " + pilha.Count()); 


        try
        {
            pilha.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Erro esperado: " + ex.Message);
        }
    }
}





