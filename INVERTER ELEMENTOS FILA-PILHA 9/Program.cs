using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);
        fila.Enqueue(4);
        fila.Enqueue(5);

        Console.WriteLine("Fila original:");
        foreach (int item in fila)
        {
            Console.Write(item + " ");
        }

        
        Stack<int> pilha = new Stack<int>();

       
        while (fila.Count > 0)
        {
            int elemento = fila.Dequeue(); 
            pilha.Push(elemento);          
        }

    
        while (pilha.Count > 0)
        {
            int elemento = pilha.Pop();   
        }

        Console.WriteLine("\nFila invertida:");
        foreach (int item in fila)
        {
            Console.Write(item + " ");
        }
    }
}