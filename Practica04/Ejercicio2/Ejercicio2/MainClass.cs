using Practica4.Recursivos;

namespace Practica4;

public class MainClass
{
    public static void Main()
    {
        int[] valores = { 5, 10, 20, 25 };
        foreach (int n in valores)
        {
            Console.WriteLine();
            Console.WriteLine("N = " + n);

            Contador.reiniciar();
            int resultadoRec1 = AlgoritmosRecursivos.rec1(n);
            long llamadasRec1 = Contador.getOperaciones();
            Console.WriteLine("Resultado de rec1: " + resultadoRec1);
            Console.WriteLine("Llamadas de rec1: " + llamadasRec1);
            Console.WriteLine("Formula de rec1: " + AlgoritmosRecursivos.formulaRec1(n));

            Contador.reiniciar();
            int resultadoRec2 = AlgoritmosRecursivos.rec2(n);
            long llamadasRec2 = Contador.getOperaciones();
            Console.WriteLine("Resultado de rec2: " + resultadoRec2);
            Console.WriteLine("Llamadas de rec2: " + llamadasRec2);
            Console.WriteLine("Formula de rec2: " + AlgoritmosRecursivos.formulaRec2(n));

            long ganancia = llamadasRec1 / llamadasRec2;
            Console.WriteLine("Ganancia: " + ganancia + " veces");
        }
    }
}
