using Practica02_Strategy.Objetos;

namespace Practica02_Strategy.Strategy
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
