using Practica02_Decorator.Objetos;

namespace Practica02_Decorator.Decorator
{
    public abstract class DecoradorSuscriptor : IMostrable
    {
        protected IMostrable componente;

        public DecoradorSuscriptor(IMostrable objetoRecibido)
        {
            this.componente = objetoRecibido;
        }

        public abstract string mostrarInfo();

        public Suscriptor getSuscriptor()
        {
            return componente.getSuscriptor();
        }
    }
}
