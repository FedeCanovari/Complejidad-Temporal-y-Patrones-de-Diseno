using Practica02_Decorator.Objetos;

namespace Practica02_Decorator.Decorator
{
    public class DecoradorAntiguedad : DecoradorSuscriptor
    {
        public DecoradorAntiguedad(IMostrable objetoRecibido)
            : base(objetoRecibido)
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
