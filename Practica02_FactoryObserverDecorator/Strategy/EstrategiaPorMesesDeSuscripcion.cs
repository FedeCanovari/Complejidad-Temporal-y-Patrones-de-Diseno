using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.Strategy
{
    public class EstrategiaPorMesesDeSuscripcion : EstrategiaDeComparacion
    {
        public bool sosIgual(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getMesesDeSuscripcion() ==
                   suscriptor2.getMesesDeSuscripcion();
        }

        public bool sosMenor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getMesesDeSuscripcion() <
                   suscriptor2.getMesesDeSuscripcion();
        }

        public bool sosMayor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getMesesDeSuscripcion() >
                   suscriptor2.getMesesDeSuscripcion();
        }
    }
}
