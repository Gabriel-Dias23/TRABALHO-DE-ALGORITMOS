class Posfixa
{
    public static int Calcular(string expressao)
    {
        Stack<int> pilha = new Stack<int>();
        string[] tokens = expressao.Split(' ');

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int num))
                pilha.Push(num);
            else
            {
                int b = pilha.Pop();
                int a = pilha.Pop();
                switch (token)
                {
                    case "+": pilha.Push(a + b); break;
                    case "-": pilha.Push(a - b); break;
                    case "*": pilha.Push(a * b); break;
                    case "/": pilha.Push(a / b); break;
                }
            }
        }

        return pilha.Pop();
    }

    public static void Main()
    {
        Console.WriteLine("Resultado posfixa: " + Posfixa.Calcular("3 4 + 2 *"));
    }
}