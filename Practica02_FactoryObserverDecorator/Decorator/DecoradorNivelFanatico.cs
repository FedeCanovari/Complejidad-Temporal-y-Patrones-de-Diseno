namespace Practica02_FactoryObserverDecorator.Decorator
{
    public class DecoradorNivelFanatico : DecoradorSuscriptor
    {
        public DecoradorNivelFanatico(IMostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            int horas =
                getSuscriptor().getHorasVistas();

            string nivel;

            if (horas < 10)
            {
                nivel = "Bronce";
            }
            else if (horas < 50)
            {
                nivel = "Plata";
            }
            else
            {
                nivel = "Oro";
            }

            return "[" + nivel + "] " +
                   componente.mostrarInfo();
        }
    }
}