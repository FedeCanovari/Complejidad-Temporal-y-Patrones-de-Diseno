using Practica4.Proxy;

namespace Practica4;

public class MainClass
{
    public static void Main()
    {
        ejercicio4();
    }

    public static void ejercicio4()
    {
        int cantidadDeAlumnos = 10000;
        int cantidadDeConsultas = 1000;
        int legajoBuscado = 10000;

        ServicioDeAlumnos servicio = new ServicioDeAlumnos(cantidadDeAlumnos);
        Contador.reiniciar();

        // Primero buscamos siempre el mismo alumno sin usar la cache.
        for (int i = 0; i < cantidadDeConsultas; i++)
        {
            servicio.buscarAlumno(legajoBuscado);
        }

        long comparacionesSinProxy = Contador.getOperaciones();

        ServicioDeAlumnos servicioParaElProxy = new ServicioDeAlumnos(cantidadDeAlumnos);
        ServicioDeAlumnosConCache proxy = new ServicioDeAlumnosConCache(servicioParaElProxy);

        Contador.reiniciar();

        // Ahora repetimos las consultas usando el proxy con cache.
        for (int i = 0; i < cantidadDeConsultas; i++)
        {
            proxy.buscarAlumno(legajoBuscado);
        }

        long comparacionesConProxy = Contador.getOperaciones();
        long ganancia = comparacionesSinProxy / comparacionesConProxy;

        Console.WriteLine("EJERCICIO 4");
        Console.WriteLine("Comparaciones sin Proxy: " + comparacionesSinProxy);
        Console.WriteLine("Comparaciones con Proxy: " + comparacionesConProxy);
        Console.WriteLine("Ganancia: " + ganancia + " veces");
    }
}
