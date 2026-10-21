using Practica02_Observer.Interfaces;
using Practica02_Observer.Objetos;
using Practica02_Observer.Strategy;

namespace Practica02_Observer.FactoryMethod
{
    public class FabricaDeSuscriptores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            Suscriptor suscriptor = new Suscriptor(
                generador.stringAleatorio(),
                generador.numeroAleatorio(10000),
                generador.numeroAleatorio(120),
                generador.numeroAleatorio(2000)
            );

            suscriptor.setEstrategia(
                new EstrategiaPorNombre()
            );

            return suscriptor;
        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("Nombre: ");
            string nombre = lector.stringPorTeclado();

            Console.Write("ID: ");
            int id = lector.numeroPorTeclado();

            Console.Write("Meses de suscripción: ");
            int meses = lector.numeroPorTeclado();

            Console.Write("Horas vistas: ");
            int horas = lector.numeroPorTeclado();

            Suscriptor suscriptor =
                new Suscriptor(nombre, id, meses, horas);

            suscriptor.setEstrategia(
                new EstrategiaPorNombre()
            );

            return suscriptor;
        }
    }
}
