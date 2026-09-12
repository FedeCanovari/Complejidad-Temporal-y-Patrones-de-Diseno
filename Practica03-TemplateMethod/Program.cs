namespace Practica03_TemplateMethod;

public class Program
{
    public static void Main(string[] args)
    {
        PreparadorDeCafe cafe = new PreparadorDeCafe();
        PreparadorDeTe te = new PreparadorDeTe();

        Console.WriteLine("Preparando café:");
        cafe.prepararBebida();

        Console.WriteLine();

        Console.WriteLine("Preparando té:");
        te.prepararBebida();
    }
}