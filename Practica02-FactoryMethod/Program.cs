using Practica02_FactoryMethod.Colecciones;
using Practica02_FactoryMethod.FactoryMethod;
using Practica02_FactoryMethod.Interfaces;

namespace Practica02_FactoryMethod
{
    public class Program
    {
        public const int VISUALIZACION = 1;
        public const int SUSCRIPTOR = 2;

        public static void llenar(Coleccionable coleccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                coleccionable.agregar(comparable);
            }
        }

        public static void informar(Coleccionable coleccionable, int opcion)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos());
            Console.WriteLine("Mínimo: " + coleccionable.minimo());
            Console.WriteLine("Máximo: " + coleccionable.maximo());

            Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);

            if (coleccionable.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }

        public static void Main(string[] args)
        {
            Pila visualizaciones = new Pila();
            Pila suscriptores = new Pila();
            llenar(visualizaciones, VISUALIZACION);
            llenar(suscriptores, SUSCRIPTOR);

            Console.WriteLine("VISUALIZACIONES CREADAS POR FÁBRICA");
            Console.WriteLine("Cantidad: " + visualizaciones.cuantos());
            Console.WriteLine("Mínimo: " + visualizaciones.minimo());
            Console.WriteLine("Máximo: " + visualizaciones.maximo());

            Console.WriteLine("\nSUSCRIPTORES CREADOS POR FÁBRICA");
            Console.WriteLine("Cantidad: " + suscriptores.cuantos());
            Console.WriteLine("Mínimo: " + suscriptores.minimo());
            Console.WriteLine("Máximo: " + suscriptores.maximo());

        }
    }
}
