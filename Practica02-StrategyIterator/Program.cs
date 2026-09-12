using Practica02_StrategyIterator.Colecciones;
using Practica02_StrategyIterator.Interfaces;
using Practica02_StrategyIterator.Objetos;
using Practica02_StrategyIterator.Strategy;
using Practica02_StrategyIterator.Iterator;

namespace Practica02_StrategyIterator
{
    public class Program
    {
        static Random rnd = new Random();

        public static void llenarSuscriptores(Coleccionable c)
        {
            try
            {
                string[] nombres =
                {
                    "Ana", "Bruno", "Carla", "Diego", "Elena",
                    "Facundo", "Gisela", "Hugo", "Irene", "Juan"
                };

                for (int i = 0; i < 20; i++)
                {
                    string nombre = nombres[rnd.Next(nombres.Length)];
                    int id = rnd.Next(1000, 10000);
                    int meses = rnd.Next(1, 121);
                    int horas = rnd.Next(1, 2001);

                    Suscriptor s = new Suscriptor(nombre, id, meses, horas);

                    s.setEstrategia(new EstrategiaPorNombre());

                    c.agregar(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    "Error al llenar suscriptores: " + e.Message
                );
            }
        }

        // Iterar e imprimir elementos de una colección
        public static void imprimirElementos(Iterable iterable)
        {
            Iterador iterador = iterable.crearIterador();

            iterador.primero();

            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual());

                iterador.siguiente();
            }
        }

        public static void cambiarEstrategia(
             Coleccionable coleccionable,
            EstrategiaDeComparacion estrategia)
        {
            Iterable iterable = (Iterable)coleccionable;

            Iterador iterador = iterable.crearIterador();

            iterador.primero();

            while (!iterador.fin())
            {
                Suscriptor suscriptor = (Suscriptor)iterador.actual();

                suscriptor.setEstrategia(estrategia);

                iterador.siguiente();
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos());
            Console.WriteLine("Mínimo: " + coleccionable.minimo());
            Console.WriteLine("Máximo: " + coleccionable.maximo());
        }

        public static void Main(string[] args)
        {
            Pila pila = new Pila();

            llenarSuscriptores(pila);

            Console.WriteLine("COMPARACIÓN POR NOMBRE");
            cambiarEstrategia(pila, new EstrategiaPorNombre());
            informar(pila);

            Console.WriteLine("\nCOMPARACIÓN POR MESES DE SUSCRIPCIÓN");
            cambiarEstrategia(pila, new EstrategiaPorMesesDeSuscripcion());
            informar(pila);

            Console.WriteLine("\nCOMPARACIÓN POR HORAS VISTAS");
            cambiarEstrategia(pila, new EstrategiaPorHorasVistas());
            informar(pila);

            Console.WriteLine("\nCOMPARACIÓN POR ID");
            cambiarEstrategia(pila, new EstrategiaPorId());
            informar(pila);
        }
    }
}