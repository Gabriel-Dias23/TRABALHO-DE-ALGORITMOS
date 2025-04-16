using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.Design;
namespace PilhaVazia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> letras = new Stack<int>();

            if (letras.Count == 0) 
            {
                Console.WriteLine("A pilha está vazia !");
            }   
            

                letras.Push(1);
                letras.Push(2);
                letras.Push(3);


            foreach (int letra in letras)
            {
                Console.WriteLine(letra);
            }



            if (letras.Count > 0)
            {
                Console.WriteLine("A pilha está cheia !");
            }
            
            




            Console.ReadLine();
        }
        
           
        
        
            
     
    }
}