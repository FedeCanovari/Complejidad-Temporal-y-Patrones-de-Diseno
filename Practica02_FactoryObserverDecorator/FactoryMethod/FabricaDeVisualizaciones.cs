using Practica02_FactoryObserverDecorator.Interfaces;
using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.FactoryMethod
{
    public class FabricaDeVisualizaciones : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Visualizacion(
                generador.numeroAleatorio(100)
            );
        }

        public override Comparable crearPorTeclado()
        {
            return new Visualizacion(
                lector.numeroPorTeclado()
            );
        }
    }
}