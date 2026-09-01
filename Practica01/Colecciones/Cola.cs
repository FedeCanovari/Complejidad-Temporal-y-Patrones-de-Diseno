using System.Collections.Generic;
using Practica01.Interfaces;

namespace Practica01.Colecciones
{
    public class Cola : Coleccionable
    {
        private List<Comparable> elementos;

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public void encolar(Comparable c)
        {
            elementos.Add(c);
        }

        public Comparable desencolar()
        {
            if (elementos.Count == 0) return null;

            Comparable primero = elementos[0];
            elementos.RemoveAt(0);
            return primero;
        }

        public void agregar(Comparable comparable)
        {
            encolar(comparable);
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
    }
}