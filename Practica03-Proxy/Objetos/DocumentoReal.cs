namespace Practica03_Proxy;

public class DocumentoReal : IDocumento
{
    public DocumentoReal()
    {
        Console.WriteLine("Cargando documento real...");
    }

    public string leer(string usuario)
    {
        return "Contenido del documento";
    }
}