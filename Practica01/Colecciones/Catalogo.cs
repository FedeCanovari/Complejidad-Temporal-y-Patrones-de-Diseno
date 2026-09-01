using Practica01.Interfaces;

namespace Practica01.Colecciones
{
    public class Catalogo : Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public Catalogo(Pila p, Cola c)
        {
            pila = p;
            cola = c;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public Comparable minimo()
        {
            Comparable minimoPila = pila.minimo();
            Comparable minimoCola = cola.minimo();

            if (minimoPila.sosMenor(minimoCola))
            {
                return minimoPila;
            }

            return minimoCola;
        }

        public Comparable maximo()
        {
            Comparable maximoPila = pila.maximo();
            Comparable maximoCola = cola.maximo();

            if (maximoPila.sosMayor(maximoCola))
            {
                return maximoPila;
            }

            return maximoCola;
        }

        public void agregar(Comparable comparable)
        {
            // No hace nada según la especificación
        }

        public bool contiene(Comparable comparable)
        {
            return pila.contiene(comparable) || cola.contiene(comparable);
        }
    }
}
