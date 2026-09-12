namespace Practica03_Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        DocumentoProxy documento = new DocumentoProxy();

        Console.WriteLine(documento.leer("usuario"));
        Console.WriteLine(documento.leer("admin"));
        Console.WriteLine(documento.leer("admin"));
    }
}