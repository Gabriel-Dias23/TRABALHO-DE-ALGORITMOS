using System.Collections;
using System.Collections.Generic;
namespace Filas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            Console.Write("\n João");
            Console.Write("\n Maria");
            Console.Write("\n José");



            fila.Enqueue("João");
            fila.Enqueue("Maria");
            fila.Enqueue("José");

            Console.WriteLine("\nPrimeiro da fila: " + fila.Peek());

            Console.WriteLine(" Removido: " + fila.Dequeue());
            Console.WriteLine(" Novo primeiro :" + fila.Peek());


            Console.WriteLine("Tamanho da fila: " + fila.Count);
        }
    }
}