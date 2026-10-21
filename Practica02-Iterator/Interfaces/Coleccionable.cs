using Practica02_Iterator.Iterator;

namespace Practica02_Iterator.Interfaces
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
