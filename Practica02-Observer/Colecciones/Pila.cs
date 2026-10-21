using System.Collections.Generic;
using Practica02_Observer.Interfaces;
using Practica02_Observer.Iterator;

namespace Practica02_Observer.Colecciones
{
    public class Pila : Coleccionable
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
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La pila está vacía");
            }

            Comparable ultimo = elementos[elementos.Count - 1];

            elementos.RemoveAt(elementos.Count - 1);

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
