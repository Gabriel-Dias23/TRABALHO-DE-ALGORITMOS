class Documento
{
    public string Nome;
    public int Prioridade;

    public Documento(string nome, int prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}

class Impressora
{
    private Queue<Documento> alta = new Queue<Documento>();
    private Queue<Documento> baixa = new Queue<Documento>();

    public void AdicionarDocumento(Documento doc)
    {
        if (doc.Prioridade == 1)
            alta.Enqueue(doc);
        else
            baixa.Enqueue(doc);
    }

    public void Imprimir()
    {
        if (alta.Count > 0)
            Console.WriteLine("Imprimindo: " + alta.Dequeue().Nome);
        else if (baixa.Count > 0)
            Console.WriteLine("Imprimindo: " + baixa.Dequeue().Nome);
        else
            Console.WriteLine("Nenhum documento na fila.");
    }

    public static void Main()
    {
        var impressora = new Impressora();
        impressora.AdicionarDocumento(new Documento("Doc1", 0));
        impressora.AdicionarDocumento(new Documento("Doc2", 1));
        impressora.Imprimir();
        impressora.Imprimir();
    }
}