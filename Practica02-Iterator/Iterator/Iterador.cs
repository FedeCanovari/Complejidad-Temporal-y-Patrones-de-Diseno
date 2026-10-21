using Practica02_Iterator.Interfaces;

namespace Practica02_Iterator.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}
