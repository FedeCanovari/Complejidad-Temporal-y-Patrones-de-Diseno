using Practica4.Strategy;

namespace Practica4;

public class MainClass
{
    public static void Main()
    {
        ejercicio3();
    }

    public static void ejercicio3()
    {
        int[] valores = { 1000, 10000, 100000, 1000000 };

        foreach (int n in valores)
        {
            ListaDeInscriptos lista = new ListaDeInscriptos(new BusquedaLineal());
            lista.cargar(n);

            // Se busca un legajo que no existe para recorrer el peor caso.
            Contador.reiniciar();
            lista.buscar(n + 1);
            long comparacionesLineal = Contador.getOperaciones();

            lista.setEstrategia(new BusquedaBinaria());
            Contador.reiniciar();
            lista.buscar(n + 1);
            long comparacionesBinaria = Contador.getOperaciones();

            long ganancia = comparacionesLineal / comparacionesBinaria;

            Console.WriteLine();
            Console.WriteLine("N = " + n);
            Console.WriteLine("Busqueda lineal: " + comparacionesLineal + " comparaciones");
            Console.WriteLine("Busqueda binaria: " + comparacionesBinaria + " comparaciones");
            Console.WriteLine("Ganancia: " + ganancia + " veces");
        }
    }
}
