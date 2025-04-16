using System;
using System.Globalization;
using System.Collections.Generic;

namespace FILAPRIORIDADESIMPLES 
{
    class Program
    {
        static void Main()
        {
            Queue<int> FilaDePrioridade = new Queue<int>();



            FilaDePrioridade.Enqueue("João", 1());
            FilaDePrioridade.Enqueue("Maria", 2());
            FilaDePrioridade.Enqueue("Pedro" 3());

            Console.WriteLine("Ordem fila:" + FilaDePrioridade);

            Console.WriteLine("Atendido: " + FilaDePrioridade.Dequeue()); 
            Console.WriteLine("Atendido: " + FilaDePrioridade.Dequeue());

    

            while (FilaDePrioridade.Count > 0)

            {
                int pessoa = FilaDePrioridade.Dequeue();
               
            }

            Console.ReadLine();
        }
    }
}

        
    
       
        
    





    





