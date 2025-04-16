using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
   
        Console.Write("Digite um número decimal: ");
        int numeroDecimal = int.Parse(Console.ReadLine());

     
        Stack<int> pilha = new Stack<int>();

        int numeroOriginal = numeroDecimal; 

        
        while (numeroDecimal > 0)
        {
            int resto = numeroDecimal % 2;  
            pilha.Push(resto);              
            numeroDecimal = numeroDecimal / 2; 
        }

       
        Console.Write("Número binário de " + numeroOriginal + " é: ");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop()); 
        }

        Console.WriteLine(); 
    }
}
