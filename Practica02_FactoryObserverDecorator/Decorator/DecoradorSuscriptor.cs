using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.Decorator
{
    public abstract class DecoradorSuscriptor : IMostrable
    {
        protected IMostrable componente;

        public DecoradorSuscriptor(IMostrable componente)
        {
            this.componente = componente;
        }

        public abstract string mostrarInfo();

        public Suscriptor getSuscriptor()
        {
            return componente.getSuscriptor();
        }
    }
} 