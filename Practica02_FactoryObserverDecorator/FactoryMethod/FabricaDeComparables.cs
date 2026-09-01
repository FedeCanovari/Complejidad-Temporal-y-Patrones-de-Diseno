using Practica02_FactoryObserverDecorator.Interfaces;

namespace Practica02_FactoryObserverDecorator.FactoryMethod
{
    public abstract class FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios generador;
        protected LectorDeDatos lector;

        public FabricaDeComparables()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }

        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeVisualizaciones();
                    break;

                case 2:
                    fabrica = new FabricaDeSuscriptores();
                    break;
            }

            return fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeVisualizaciones();
                    break;

                case 2:
                    fabrica = new FabricaDeSuscriptores();
                    break;
            }

            return fabrica.crearPorTeclado();
        }

        public abstract Comparable crearAleatorio();

        public abstract Comparable crearPorTeclado();
    }
}