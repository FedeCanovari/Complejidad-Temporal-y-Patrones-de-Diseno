using Practica02_StrategyIterator.Interfaces;
using Practica02_StrategyIterator.Objetos;
using Practica02_StrategyIterator.Strategy;

namespace Practica02_StrategyIterator.Objetos
{
    public class Suscriptor : Perfil
    {
        private int mesesDeSuscripcion;
        private int horasVistas;
        private EstrategiaDeComparacion estrategia;

        public Suscriptor(string n, int i, int c, int h) : base(n, i)
        {
            mesesDeSuscripcion = c;
            horasVistas = h;
        }

        public int getMesesDeSuscripcion()
        {
            return mesesDeSuscripcion;
        }

        public int getHorasVistas()
        {
            return horasVistas;
        }

        public override string ToString()
        {
            return getNombre() +
                   " - ID: " + getId() +
                   " - Meses: " + mesesDeSuscripcion +
                   " - Horas: " + horasVistas;
        }

        public override bool sosIgual(Comparable comparable)
        {
            Suscriptor suscriptor = (Suscriptor)comparable;

            return estrategia.sosIgual(this, suscriptor);
        }

        public override bool sosMenor(Comparable comparable)
        {
            Suscriptor suscriptor = (Suscriptor)comparable;

            return estrategia.sosMenor(this, suscriptor);
        }

        public override bool sosMayor(Comparable comparable)
        {
            Suscriptor suscriptor = (Suscriptor)comparable;

            return estrategia.sosMayor(this, suscriptor);
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            this.estrategia = estrategia;
        }
    }
}