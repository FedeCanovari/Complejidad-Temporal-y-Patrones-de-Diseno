using Practica02_Iterator.Colecciones;
using Practica02_Iterator.Interfaces;
using Practica02_Iterator.Iterator;
using Practica02_Iterator.Objetos;
using Practica02_Iterator.Strategy;

namespace Practica02_Iterator
{
    public class Program
    {
        static Random rnd = new Random();

        public static void llenarSuscriptores(Coleccionable c)
        {
            string[] nombres =
            {
                "Ana", "Bruno", "Carla", "Diego", "Elena",
                "Facundo", "Gisela", "Hugo", "Irene", "Juan"
            };

            for (int i = 0; i < 20; i++)
            {
                Suscriptor suscriptor = new Suscriptor(
                    nombres[rnd.Next(nombres.Length)],
                    rnd.Next(1000, 10000),
                    rnd.Next(1, 121),
                    rnd.Next(1, 2001));

                suscriptor.setEstrategia(new EstrategiaPorNombre());
                c.agregar(suscriptor);
            }
        }

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

        public static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Playlist playlist = new Playlist();

            llenarSuscriptores(pila);
            llenarSuscriptores(cola);
            llenarSuscriptores(playlist);

            Console.WriteLine("PILA");
            imprimirElementos(pila);
            Console.WriteLine("\nCOLA");
            imprimirElementos(cola);
            Console.WriteLine("\nPLAYLIST");
            imprimirElementos(playlist);
        }
    }
}
