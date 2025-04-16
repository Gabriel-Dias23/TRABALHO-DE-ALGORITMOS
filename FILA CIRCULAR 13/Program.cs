using System.Collections;
using System.Collections.Generic;

Queue<string> filaCircular = new Queue<string>();

internal class FilaCircular<T>

{

    static void Main()
    {
        Queue<string> filaCircular = new Queue<string>();

    }
   public T[] itens;  
    public int tamanho;
    public int inicio;
    public int fim;
    public int total;

    public FilaCircular(int capacidade)
    {
        itens = new T[capacidade];
        tamanho = capacidade;
        inicio = 0;
        fim = 0;
        total = 0;
    }

    public bool IsEmpty()
    {
        return total == 0;
    }

    public bool IsFull()
    {
        return total == tamanho;
    }

    public void Enqueue(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Fila cheia! Não é possível adicionar.");
            return;
        }

        itens[fim] = item;
        fim = (fim + 1) % tamanho;
        total++;
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Fila vazia!");

        T item = itens[inicio];
        inicio = (inicio + 1) % tamanho;
        total--;
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Fila vazia!");

        return itens[inicio];
    }

    public void Print()
    {
        Console.Write("Fila: ");
        for (int i = 0; i < total; i++)
        {
            int index = (inicio + i) % tamanho;
            Console.Write(itens[index] + " ");
        }
        Console.WriteLine();


    }
}
    
       

    


 

