using Practica01.Interfaces;

namespace Practica01.Objetos
{
    public class Suscriptor : Perfil
    {
        private int mesesDeSuscripcion;
        private int horasVistas;

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

            return mesesDeSuscripcion == suscriptor.getMesesDeSuscripcion();
        }

        public override bool sosMenor(Comparable comparable)
        {
            Suscriptor suscriptor = (Suscriptor)comparable;

            return mesesDeSuscripcion < suscriptor.getMesesDeSuscripcion();
        }

        public override bool sosMayor(Comparable comparable)
        {
            Suscriptor suscriptor = (Suscriptor)comparable;

            return mesesDeSuscripcion > suscriptor.getMesesDeSuscripcion();
        }
    }
}