class Editor
{
    private Stack<string> undo = new Stack<string>();
    private Stack<string> redo = new Stack<string>();
    private string texto = "";

    public void Digitar(string novo)
    {
        undo.Push(texto);
        texto = novo;
        redo.Clear();
    }

    public void Undo()
    {
        if (undo.Count > 0)
        {
            redo.Push(texto);
            texto = undo.Pop();
        }
    }

    public void Redo()
    {
        if (redo.Count > 0)
        {
            undo.Push(texto);
            texto = redo.Pop();
        }
    }

    public void Mostrar() => Console.WriteLine("Texto atual: " + texto);

    public static void Main()
    {
        var editor = new Editor();
        editor.Digitar("Texto 1");
        editor.Digitar("Texto 2");
        editor.Undo();
        editor.Redo();
        editor.Mostrar();
    }
}
