
class Estacionamento
{
    private Stack<string> pilha = new Stack<string>();
    private const int capacidade = 5;

    public void Entrar(string carro)
    {
        if (pilha.Count < capacidade)
            pilha.Push(carro);
        else
            Console.WriteLine("Estacionamento cheio!");
    }

    public void Sair(string carro)
    {
        Stack<string> temp = new Stack<string>();

        while (pilha.Count > 0 && pilha.Peek() != carro)
            temp.Push(pilha.Pop());

        if (pilha.Count == 0)
        {
            Console.WriteLine("Carro não está no estacionamento.");
        }
        else
        {
            pilha.Pop();
            Console.WriteLine($"{carro} saiu do estacionamento.");
        }

        while (temp.Count > 0)
            pilha.Push(temp.Pop());
    }

    public static void Main()
    {
        var estacionamento = new Estacionamento();
        estacionamento.Entrar("Carro1");
        estacionamento.Entrar("Carro2");
        estacionamento.Entrar("Carro3");
        estacionamento.Sair("Carro2");
    }
}
