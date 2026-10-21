using Practica02_Observer.Interfaces;

namespace Practica02_Observer.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}
