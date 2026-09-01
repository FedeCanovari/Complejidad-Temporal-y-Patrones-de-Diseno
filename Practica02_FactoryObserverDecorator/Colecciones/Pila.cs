using System.Collections.Generic;
using Practica02_FactoryObserverDecorator.Interfaces;
using Practica02_FactoryObserverDecorator.Iterator;

namespace Practica02_FactoryObserverDecorator.Colecciones
{
    public class Pila : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        } 
        public Pila()
        {
            elementos = new List<Comparable>();
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public void apilar(Comparable c)
        {
            elementos.Add(c);
        }

        public Comparable desapilar()
        {
            if (elementos.Count == 0) return null;

            int lastIndex = elementos.Count - 1;
            Comparable ultimo = elementos[lastIndex];
            elementos.RemoveAt(lastIndex);
            return ultimo;
        }

        public void agregar(Comparable comparable)
        {
            apilar(comparable);
        }

        public bool contiene(Comparable comparable)
        {
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }

            return false;
        }

        public Comparable minimo()
        {
            Comparable minimo = elementos[0];

            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMenor(minimo))
                {
                    minimo = elemento;
                }
            }

            return minimo;
        }

        public Comparable maximo()
        {
            Comparable maximo = elementos[0];

            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMayor(maximo))
                {
                    maximo = elemento;
                }
            }

            return maximo;
        }

        public List<Comparable> getElementos()
        {
            return elementos;
        } 
    }
}
