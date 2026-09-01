using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.Decorator
{
    public class DecoradorAntiguedad : DecoradorSuscriptor
    {
        public DecoradorAntiguedad(IMostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            string info = componente.mostrarInfo();

            Suscriptor suscriptor = getSuscriptor();

            return info.Replace(
                " - ",
                " (Suscriptor hace " +
                suscriptor.getMesesDeSuscripcion() +
                " meses) - "
            );
        }
    }
}