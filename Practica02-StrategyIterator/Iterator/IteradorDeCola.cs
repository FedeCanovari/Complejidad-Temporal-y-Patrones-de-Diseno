using Practica02_StrategyIterator.Interfaces;
using Practica02_StrategyIterator.Colecciones;

namespace Practica02_StrategyIterator.Iterator
{
    public class IteradorDeCola : Iterador
    {
        private Cola cola;
        private int posicion;

        public IteradorDeCola(Cola cola)
        {
            this.cola = cola;
            primero();
        }

        public void primero()
        {
            posicion = 0;
        }

        public void siguiente()
        {
            posicion++;
        }

        public bool fin()
        {
            return posicion >= cola.cuantos();
        }

        public Comparable actual()
        {
            return cola.getElementos()[posicion];
        }
    }
}