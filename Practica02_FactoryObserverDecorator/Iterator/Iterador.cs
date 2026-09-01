using Practica02_FactoryObserverDecorator.Interfaces;

namespace Practica02_FactoryObserverDecorator.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
} 
