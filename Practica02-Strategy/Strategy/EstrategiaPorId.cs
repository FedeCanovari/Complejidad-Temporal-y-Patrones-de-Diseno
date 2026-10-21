using Practica02_Strategy.Objetos;

namespace Practica02_Strategy.Strategy
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
