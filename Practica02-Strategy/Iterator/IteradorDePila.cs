using Practica02_Strategy.Interfaces;
using Practica02_Strategy.Colecciones;

namespace Practica02_Strategy.Iterator
{
    public class IteradorDePila : Iterador
    {
        private Pila pila;
        private int posicion;

        public IteradorDePila(Pila pila)
        {
            this.pila = pila;
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
            return posicion >= pila.cuantos();
        }

        public Comparable actual()
        {
            return pila.getElementos()[posicion];
        }
    }
}
