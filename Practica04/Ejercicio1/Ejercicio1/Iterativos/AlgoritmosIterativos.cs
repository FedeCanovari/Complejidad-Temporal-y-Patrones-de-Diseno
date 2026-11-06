namespace Practica4.Iterativos;

public class AlgoritmosIterativos
{
    public static void contar(int n)
    {
        // El ciclo se repite n veces.
        for (int i = 1; i <= n; i++)
        {
            Contador.sumar();
        }
    }

    public static void contar2(int n)
    {
        // Cada ciclo va desde 0 hasta n, por eso se repite n + 1 veces.
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                Contador.sumar();
            }
        }
    }

    public static void contarDependiente(int n)
    {
        // El segundo ciclo llega hasta i: primero cuenta 1 vez, despues 2, etc.
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Contador.sumar();
            }
        }
    }

    public static void tiempoWhile(int n)
    {
        int i = 1;

        while (i < n)
        {
            Contador.sumar();
            i = i * 2; // En cada vuelta, i vale el doble.
        }
    }

    public static long formulaContar(int n)
    {
        return n;
    }

    public static long formulaContar2(int n)
    {
        long vueltasDeCadaCiclo = (long)n + 1;
        long cantidadDeOperaciones = vueltasDeCadaCiclo * vueltasDeCadaCiclo;
        return cantidadDeOperaciones;
    }

    public static long formulaDependiente(int n)
    {
        // Es la suma de todos los numeros desde 1 hasta n.
        long cantidadDeOperaciones = (long)n * (n + 1L) / 2;
        return cantidadDeOperaciones;
    }

    public static long formulaWhile(int n)
    {
        if (n <= 1)
        {
            return 0;
        }

        // Log2 calcula el logaritmo en base 2 y Ceiling redondea hacia arriba.
        double logaritmo = Math.Log2(n);
        double redondeado = Math.Ceiling(logaritmo);
        long cantidadDeOperaciones = (long)redondeado;
        return cantidadDeOperaciones;
    }
}
