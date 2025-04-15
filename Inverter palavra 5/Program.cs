using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //  Pedir ao usuário que digite uma palavra
        Console.Write("Digite uma palavra: ");
        string palavraOriginal = Console.ReadLine();

        //  Criar uma pilha de caracteres
        Stack<char> pilha = new Stack<char>();

        //  Empilhar cada caractere da palavra
        foreach (char letra in palavraOriginal)
        {
            pilha.Push(letra);
        }

        // Desempilhar as letras e formar a palavra invertida
        string palavraInvertida = "";

        while (pilha.Count > 0)
        {
            char letra = pilha.Pop();
            palavraInvertida += letra; 
        }

        //  Exibir a palavra invertida
        Console.WriteLine($"Palavra invertida: {palavraInvertida}");
    }
}