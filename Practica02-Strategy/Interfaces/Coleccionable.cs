using Practica02_Strategy.Iterator;

namespace Practica02_Strategy.Interfaces
{
    public interface Coleccionable : Iterable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable comparable);
        bool contiene(Comparable comparable);
    }
}
