using System.Collections;
using System.Collections.Generic;
namespace FilaAtendimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaAtendimento = new Queue<string>();

           filaAtendimento.Enqueue("Cliente 1");
           filaAtendimento.Enqueue("Cliente 2");
           filaAtendimento.Enqueue("Cliente 3");

           while(filaAtendimento.Count > 0)
            {
                Console.WriteLine("Prioridade de atendimento: "+ filaAtendimento.Dequeue());
            }
        }
    }
}