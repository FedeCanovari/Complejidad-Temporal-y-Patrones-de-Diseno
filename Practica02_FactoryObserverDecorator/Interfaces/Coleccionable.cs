using Practica02_FactoryObserverDecorator.Iterator;

namespace Practica02_FactoryObserverDecorator.Interfaces
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
