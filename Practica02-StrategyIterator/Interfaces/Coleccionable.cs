using Practica02_StrategyIterator.Iterator;

namespace Practica02_StrategyIterator.Interfaces
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