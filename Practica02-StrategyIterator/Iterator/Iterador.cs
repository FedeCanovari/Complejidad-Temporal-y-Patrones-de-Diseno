using Practica02_StrategyIterator.Interfaces;

namespace Practica02_StrategyIterator.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
} 