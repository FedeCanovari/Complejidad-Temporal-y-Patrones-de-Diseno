using Practica02_StrategyIterator.Objetos;

namespace Practica02_StrategyIterator.Strategy
{
    public class EstrategiaPorId : EstrategiaDeComparacion
    {
        public bool sosIgual(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getId() == suscriptor2.getId();
        }

        public bool sosMenor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getId() < suscriptor2.getId();
        }

        public bool sosMayor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getId() > suscriptor2.getId();
        }
    }
}