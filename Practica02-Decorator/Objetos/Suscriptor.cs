using Practica02_Decorator.Decorator;

namespace Practica02_Decorator.Objetos
{
    public class Suscriptor : Perfil, IMostrable
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

        public string mostrarInfo()
        {
            return getNombre() + " - " +
                   getHorasVistas() + " horas vistas";
        }

        public Suscriptor getSuscriptor()
        {
            return this;
        }
    }
}
