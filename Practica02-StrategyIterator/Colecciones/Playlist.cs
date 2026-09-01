using Practica02_StrategyIterator.Interfaces;
using Practica02_StrategyIterator.Iterator;

namespace Practica02_StrategyIterator.Colecciones
{
    public class Playlist : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Playlist()
        {
            elementos = new List<Comparable>();
        }

        public void agregar(Comparable elemento)
        {
            if (!pertenece(elemento))
            {
                elementos.Add(elemento);
            }
        }

        public Iterador crearIterador()
        {
            return new IteradorDePlaylist(this);
        }

        public bool pertenece(Comparable elemento)
        {
            foreach (Comparable e in elementos)
            {
                if (e.sosIgual(elemento))
                {
                    return true;
                }
            }

            return false;
        }

        public int cuantos()
        {
            return elementos.Count;
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

        public bool contiene(Comparable elemento)
        {
            return pertenece(elemento);
        }

        public List<Comparable> getElementos()
        {
            return elementos;
        }
    }
}