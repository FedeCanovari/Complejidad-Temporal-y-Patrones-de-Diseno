using Practica02_Iterator.Interfaces;
using Practica02_Iterator.Colecciones;

namespace Practica02_Iterator.Iterator
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
