using Practica02_Decorator.Objetos;

namespace Practica02_Decorator.Decorator
{
    public class DecoradorEstadoCuenta : DecoradorSuscriptor
    {
        public DecoradorEstadoCuenta(IMostrable objetoRecibido)
            : base(objetoRecibido)
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
