using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> historico = new Stack<string>();
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Acessar nova página");
            Console.WriteLine("2 - Voltar para página anterior");
            Console.WriteLine("3 - Mostrar página atual");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a URL da nova página: ");
                    string novaPagina = Console.ReadLine();
                    historico.Push(novaPagina); 
                    Console.WriteLine($"Você acessou: {novaPagina}");
                    break;

                case "2":
                    if (historico.Count > 0)
                    {
                        string paginaRemovida = historico.Pop(); 
                        if (historico.Count > 0)
                        {
                            Console.WriteLine($"Você voltou para: {historico.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("Você voltou para a página inicial (sem histórico).");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma página para voltar.");
                    }
                    break;

                case "3":
                    if (historico.Count > 0)
                    {
                        Console.WriteLine($"Página atual: {historico.Peek()}");
                    }
                    else
                    {
                        Console.WriteLine("Você está na página inicial.");
                    }
                    break;

                case "0":
                    executando = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}