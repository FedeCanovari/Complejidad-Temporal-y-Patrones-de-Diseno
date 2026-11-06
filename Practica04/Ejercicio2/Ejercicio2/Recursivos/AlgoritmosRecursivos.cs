namespace Practica4.Recursivos;

public class AlgoritmosRecursivos
{
    public static int rec1(int n)
    {
        Contador.sumar();

        if (n <= 1)
        {
            // Caso base: aca termina la recursion.
            return 1;
        }
        else
        {
            // Se vuelve a llamar dos veces con el mismo valor.
            int primerResultado = rec1(n - 1);
            int segundoResultado = rec1(n - 1);
            int resultado = primerResultado + segundoResultado;
            return resultado;
        }
    }

    public static int rec2(int n)
    {
        Contador.sumar();

        if (n <= 1)
        {
            return 1;
        }
        else
        {
            // Se hace una sola llamada y se multiplica su resultado por 2.
            int resultadoDeLaLlamada = rec2(n - 1);
            int resultado = 2 * resultadoDeLaLlamada;
            return resultado;
        }
    }

    public static long formulaRec1(int n)
    {
        // La formula para n mayor o igual a 1 es 2 elevado a n, menos 1.
        long potencia = 1;
        for (int i = 0; i < n; i++)
        {
            potencia = potencia * 2;
        }

        long cantidadDeLlamadas = potencia - 1;
        return cantidadDeLlamadas;
    }

    public static long formulaRec2(int n)
    {
        // Para n mayor o igual a 1, rec2 se llama n veces.
        long cantidadDeLlamadas = n;
        return cantidadDeLlamadas;
    }
}
