using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.Write("Digite a sequência de parênteses: ");
        string entrada = "nome";


        Stack<char> pilha = new Stack<char>();


        foreach (char c in entrada)
        {
            if (c == '(')
            {
                pilha.Push(c);
            }
            else if (c == ')')
            {
                if (pilha.Count == 0)
                {
                    Console.WriteLine("Sequência inválida! Parêntese fechando sem abrir.");
                    return;
                }
                pilha.Pop();
            }
        }

        if (pilha.Count == 0)
        {
            Console.WriteLine("Sequência BALANCEADA!");
        }
        else
        {
            Console.WriteLine("Sequência INVÁLIDA! Parênteses não foram fechados.");
        }
        


        Console.ReadKey();

        
    }
}