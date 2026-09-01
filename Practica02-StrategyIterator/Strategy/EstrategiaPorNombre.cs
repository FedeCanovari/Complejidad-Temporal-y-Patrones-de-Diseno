using Practica02_StrategyIterator.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica02_StrategyIterator.Strategy
{
    public class EstrategiaPorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return suscriptor1.getNombre() == suscriptor2.getNombre();
        }

        public bool sosMenor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return string.Compare(suscriptor1.getNombre(), suscriptor2.getNombre()) < 0;
        }

        public bool sosMayor(Suscriptor suscriptor1, Suscriptor suscriptor2)
        {
            return string.Compare(suscriptor1.getNombre(), suscriptor2.getNombre()) > 0;
        }
    }
}
