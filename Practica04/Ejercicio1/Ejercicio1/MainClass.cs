using Practica4.Iterativos;

namespace Practica4;

public class MainClass
{
    public static void Main()
    {
        int[] valores = { 10, 100, 1000 };
        foreach (int n in valores)
        {
            Console.WriteLine();
            Console.WriteLine("N = " + n);

            Contador.reiniciar();
            AlgoritmosIterativos.contar(n);
            Console.WriteLine("contar: " + Contador.getOperaciones() + " operaciones");
            Console.WriteLine("Formula: " + AlgoritmosIterativos.formulaContar(n));
            Console.WriteLine("Orden: O(n)");

            Contador.reiniciar();
            AlgoritmosIterativos.contar2(n);
            Console.WriteLine("contar2: " + Contador.getOperaciones() + " operaciones");
            Console.WriteLine("Formula: " + AlgoritmosIterativos.formulaContar2(n));
            Console.WriteLine("Orden: O(n^2)");

            Contador.reiniciar();
            AlgoritmosIterativos.contarDependiente(n);
            Console.WriteLine("contarDependiente: " + Contador.getOperaciones() + " operaciones");
            Console.WriteLine("Formula: " + AlgoritmosIterativos.formulaDependiente(n));
            Console.WriteLine("Orden: O(n^2)");

            Contador.reiniciar();
            AlgoritmosIterativos.tiempoWhile(n);
            Console.WriteLine("tiempoWhile: " + Contador.getOperaciones() + " operaciones");
            Console.WriteLine("Formula: " + AlgoritmosIterativos.formulaWhile(n));
            Console.WriteLine("Orden: O(log n)");
        }
    }
}
