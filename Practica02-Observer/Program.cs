using Practica02_Observer.Colecciones;
using Practica02_Observer.FactoryMethod;
using Practica02_Observer.Interfaces;
using Practica02_Observer.Iterator;
using Practica02_Observer.Objetos;
using Practica02_Observer.Observer;

namespace Practica02_Observer
{
    public class Program
    {
        private const int SUSCRIPTOR = 2;

        public static void llenarConSuscriptores(Coleccionable coleccionable, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                coleccionable.agregar(FabricaDeComparables.crearAleatorio(SUSCRIPTOR));
            }
        }

        public static void registrarObservadores(Iterable iterable, Canal canal)
        {
            Iterador iterador = iterable.crearIterador();
            iterador.primero();

            while (!iterador.fin())
            {
                canal.agregarObservador((Suscriptor)iterador.actual());
                iterador.siguiente();
            }
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
            Canal canal = new FabricaDeCanales().crearAleatorio();
            Pila suscriptores = new Pila();
            llenarConSuscriptores(suscriptores, 10);
            registrarObservadores(suscriptores, canal);
            temporadaDeContenido(canal);
        }
    }
}
