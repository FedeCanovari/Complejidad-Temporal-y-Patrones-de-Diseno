using Practica02_FactoryObserverDecorator.Observer;

namespace Practica02_FactoryObserverDecorator.FactoryMethod
{
    public class FabricaDeCanales
    {
        private GeneradorDeDatosAleatorios generador;
        private LectorDeDatos lector;

        public FabricaDeCanales()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }

        public Canal crearAleatorio()
        {
            return new Canal(
                generador.stringAleatorio()
            );
        }

        public Canal crearPorTeclado()
        {
            Console.Write("Nombre del canal: ");

            return new Canal(
                lector.stringPorTeclado()
            );
        }
    }
}