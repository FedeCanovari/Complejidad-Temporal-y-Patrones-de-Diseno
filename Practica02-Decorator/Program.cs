using Practica02_Decorator.Decorator;
using Practica02_Decorator.Objetos;

namespace Practica02_Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Suscriptor> suscriptores = new List<Suscriptor>
            {
                new Suscriptor("Ana", 1001, 18, 75),
                new Suscriptor("Bruno", 1002, 6, 25),
                new Suscriptor("Carla", 1003, 1, 5)
            };

            foreach (Suscriptor suscriptor in suscriptores)
            {
                IMostrable mostrable = suscriptor;

                mostrable = new DecoradorAntiguedad(mostrable);
                mostrable = new DecoradorNivelFanatico(mostrable);
                mostrable = new DecoradorEstadoCuenta(mostrable);
                mostrable = new DecoradorRecuadro(mostrable);

                Console.WriteLine(mostrable.mostrarInfo());
                Console.WriteLine();
            }
        }
    }
}
