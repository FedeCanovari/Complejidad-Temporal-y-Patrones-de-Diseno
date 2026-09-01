
using Practica02_FactoryObserverDecorator.Interfaces;

namespace Practica02_FactoryObserverDecorator.Interfaces
{
    public interface Comparable
    {
        bool sosIgual(Comparable comparable);
        bool sosMenor(Comparable comparable);
        bool sosMayor(Comparable comparable);
    }
}
