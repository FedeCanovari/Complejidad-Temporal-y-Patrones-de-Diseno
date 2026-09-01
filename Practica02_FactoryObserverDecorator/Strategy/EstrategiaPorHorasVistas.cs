using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.Strategy
{
    public class EstrategiaPorHorasVistas : EstrategiaDeComparacion
    {
        public bool sosIgual(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getHorasVistas() == suscriptor2.getHorasVistas();
        }

        public bool sosMenor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getHorasVistas() < suscriptor2.getHorasVistas();
        }

        public bool sosMayor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getHorasVistas() > suscriptor2.getHorasVistas();
        }
    }
}
