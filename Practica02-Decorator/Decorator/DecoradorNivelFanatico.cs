namespace Practica02_Decorator.Decorator
{
    public class DecoradorNivelFanatico : DecoradorSuscriptor
    {
        public DecoradorNivelFanatico(IMostrable objetoRecibido)
            : base(objetoRecibido)
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
