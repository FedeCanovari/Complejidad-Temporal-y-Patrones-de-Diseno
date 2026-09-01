using Practica02_FactoryObserverDecorator.Colecciones;
using Practica02_FactoryObserverDecorator.Decorator;
using Practica02_FactoryObserverDecorator.FactoryMethod;
using Practica02_FactoryObserverDecorator.Interfaces;
using Practica02_FactoryObserverDecorator.Iterator;
using Practica02_FactoryObserverDecorator.Objetos;
using Practica02_FactoryObserverDecorator.Observer;
using Practica02_FactoryObserverDecorator.Strategy;


namespace Practica02_FactoryObserverDecorator
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

        public static void llenar(Coleccionable coleccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable =
                    FabricaDeComparables.crearAleatorio(opcion);

                coleccionable.agregar(comparable);
            }
        }

        public static void informar(Coleccionable coleccionable, int opcion)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos());
            Console.WriteLine("Mínimo: " + coleccionable.minimo());
            Console.WriteLine("Máximo: " + coleccionable.maximo());

            Comparable comparable =
                FabricaDeComparables.crearPorTeclado(opcion);

            if (coleccionable.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
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

        public static void temporadaDeContenido(Canal canal)
        {
            for (int i = 0; i < 5; i++)
            {
                canal.publicarContenido();
                canal.iniciarEnVivo();
            }
        }


        public static void Main(string[] args)
        {
            const int SUSCRIPTOR = 2;

            Canal canal = new Canal("CTyPDS UNAJ");

            List<Suscriptor> suscriptores =
                new List<Suscriptor>();

            for (int i = 0; i < 10; i++)
            {
                Suscriptor suscriptor =
                    (Suscriptor)
                    FabricaDeComparables.crearAleatorio(SUSCRIPTOR);

                suscriptores.Add(suscriptor);

                canal.agregarObservador(suscriptor);
            }

            temporadaDeContenido(canal);

            Console.WriteLine("\nSUSCRIPTORES");

            foreach (Suscriptor suscriptor in suscriptores)
            {
                IMostrable mostrable = suscriptor;

                mostrable =
                    new DecoradorAntiguedad(mostrable);

                mostrable =
                    new DecoradorNivelFanatico(mostrable);

                mostrable =
                    new DecoradorEstadoCuenta(mostrable);

                mostrable =
                    new DecoradorRecuadro(mostrable);

                Console.WriteLine(
                    mostrable.mostrarInfo()
                );

                Console.WriteLine();
            }
        }





    }
}
