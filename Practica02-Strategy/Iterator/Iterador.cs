using Practica02_Strategy.Interfaces;

namespace Practica02_Strategy.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}
