using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.Design;
namespace FilaVazia
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Queue<int> Filavazia = new Queue<int>();

            if (Filavazia.Count == 0)
            {
                Console.WriteLine("A fia está vazia");

            }

            Filavazia.Enqueue(1);
            Filavazia.Enqueue(2);
            Filavazia.Enqueue(3);

            if (Filavazia.Count > 0)
            {
                Console.WriteLine("A fila está cheia");
            }


            foreach (int fila in Filavazia)
            {
                Console.WriteLine(fila);
            }



        }



    }



}