using Practica02_FactoryMethod.Interfaces;
using Practica02_FactoryMethod.Objetos;

namespace Practica02_FactoryMethod.FactoryMethod
{
    public class FabricaDeVisualizaciones : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Visualizacion(generador.numeroAleatorio(100));
        }

        public override Comparable crearPorTeclado()
        {
            return new Visualizacion(
                lector.numeroPorTeclado()
            );
        }
    }
}
