using Practica02_FactoryObserverDecorator.Objetos;

namespace Practica02_FactoryObserverDecorator.Decorator
{
    public class DecoradorEstadoCuenta : DecoradorSuscriptor
    {
        public DecoradorEstadoCuenta(IMostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            Suscriptor suscriptor =
                getSuscriptor();

            string estado;

            if (suscriptor.getHorasVistas() > 0)
            {
                estado = "Cuenta Activa";
            }
            else
            {
                estado = "Cuenta Inactiva";
            }

            string info =
                componente.mostrarInfo();

            if (info.Contains(") - "))
            {
                return info.Replace(
                    ") - ",
                    ", " + estado + ") - "
                );
            }

            return info.Replace(
                " - ",
                " (" + estado + ") - "
            );
        }
    }
}