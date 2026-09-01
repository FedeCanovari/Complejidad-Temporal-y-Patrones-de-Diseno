using Practica02_FactoryObserverDecorator.Interfaces;

namespace Practica02_FactoryObserverDecorator.Objetos
{
    public class Visualizacion : Comparable
    {
        private int cantidad;

        public Visualizacion(int c)
        {
            cantidad = c;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public bool sosIgual(Comparable c)
        {
            Visualizacion v = (Visualizacion)c;
            return cantidad == v.getCantidad();
        }

        public bool sosMenor(Comparable c)
        {
            Visualizacion v = (Visualizacion)c;
            return cantidad < v.getCantidad();
        }

        public bool sosMayor(Comparable c)
        {
            Visualizacion v = (Visualizacion)c;
            return cantidad > v.getCantidad();
        }

        public override string ToString()
        {
            return cantidad.ToString();
        }
    }
}
