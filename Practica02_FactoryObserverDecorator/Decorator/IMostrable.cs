using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.Decorator
{
    public interface IMostrable
    {
        string mostrarInfo();

        Suscriptor getSuscriptor();
    }
}