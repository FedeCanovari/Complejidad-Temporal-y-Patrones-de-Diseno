using Practica02_FactoryObserverDecorator.Interfaces;
using Practica02_FactoryObserverDecorator.Objetos;
using Practica02_FactoryObserverDecorator.Strategy;
using Practica02_FactoryObserverDecorator.Observer;
using Practica02_FactoryObserverDecorator.Decorator;

namespace Practica02_FactoryObserverDecorator.Objetos
{
    public class Suscriptor : Perfil, IObservador, IMostrable 
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

        public void verContenido()
        {
            Console.WriteLine("Viendo el nuevo contenido");
        }

        public void reaccionarANotificacion()
        {
            string[] reacciones =
            {
        "Abriendo la notificación",
        "Lo veo después",
        "Silenciando notificaciones"
    };

            Random random = new Random();

            Console.WriteLine(
                reacciones[random.Next(reacciones.Length)]
            );
        }

        public void actualizar(IObservado observado)
        {
            Canal canal = (Canal)observado;

            if (canal.estaEnVivo())
            {
                reaccionarANotificacion();
            }
            else
            {
                verContenido();
            }
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
