using Practica02_Iterator.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica02_Iterator.Strategy
{
    public interface EstrategiaDeComparacion
    {
        bool sosIgual(Suscriptor suscriptor1, Suscriptor suscriptor2);

        bool sosMenor(Suscriptor suscriptor1, Suscriptor suscriptor2);

        bool sosMayor(Suscriptor suscriptor1, Suscriptor suscriptor2);
    }
}
